using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Capa_Datos;

namespace CapaNegocio
{
    public class Administradora
    {
        private static Administradora instancia;
        private List<Infraccion> infracciones;
        private List<Vehiculo> vehiculos;
        private List<PagoInfraccion> pagosInfracciones;
       
        public Administradora()
        {
            infracciones = new List<Infraccion>();
            vehiculos = new List<Vehiculo>();
            pagosInfracciones = new List<PagoInfraccion>();
        }

        /** Permite obtener todos los vehículos de un propietario */
        public List<Vehiculo> getVehiclesByOwner(String ownerDni) {
            return vehiculos.FindAll(v => v.DniPropietario == ownerDni);
        }

        public static Administradora getInstanciaAdministradora()
        {
            if (instancia == null)
            {
                Administradora adm = new Administradora();
                instancia = adm;
            }
            return instancia;
        }

        //METODOS PARA OBTENER LISTAS
        public List<Infraccion> getInfracciones()
        {
            return infracciones;
        }

        public List<Vehiculo> getVehiculos()
        {
             return vehiculos; 
        }

        public List<PagoInfraccion> getPagosInfracciones()
        {
            return pagosInfracciones; 
        }

        //METODOS DE BUSQUEDA
        public int getSiguienteIdPagoInfraccion()
        {
            //Tener en cuenta que los id van de 0 a n y el ultimo elemento de la lista es el id mas grande
            if (pagosInfracciones.Count != 0)
            {
                int i = pagosInfracciones.Count - 1;
                return pagosInfracciones[i].Id + 1;
            }
            return 1;
        }

        public Vehiculo getVehiculo(string dominio)
        {
            Vehiculo buscarVehiculo;
            buscarVehiculo = vehiculos.Find(v => v.esVehiculo(dominio));
            return buscarVehiculo;
        }

        public Infraccion getInfraccion(string codigo)
        {
            Infraccion infraccion;
            infraccion = infracciones.Find(i => i.esInfraccion(codigo));
            return infraccion;
        }

        public Infraccion buscarInfraccion(string unCod)
        {
            foreach (var infraccion in infracciones)
            {
                if (infraccion.sos(unCod)) 
                {
                    return infraccion; // Retorna la infracción si se encuentra
                }
            }
            return null; // Retorna null si no se encuentra
        }

        //METODOS PARA AGREGAR
        public void agregarTipoInfraccion(Infraccion inf)
        {
            try
            {
                infracciones.Add(inf);

                List<string> infraData = new List<string>();
                infraData.Add(inf.Codigo);
                infraData.Add(inf.Nombre);
                infraData.Add(inf.Descripcion);
                infraData.Add(inf.Importe.ToString());

                //if para agregar el tipo de infracción
                if (inf.esInfraccionGrave())
                {
                    infraData.Add("Grave");
                }
                else
                {
                    infraData.Add("Leve");
                }
                //Guardar la infraccion en la base de datos
                Datos.GuardarInfraccion(infraData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la infracción: " + ex.Message);
            }
        }

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);

            List<string> vehicleData = new List<string>();
            vehicleData.Add(vehiculo.Dominio);
            vehicleData.Add(vehiculo.DniPropietario);
            vehicleData.Add(vehiculo.Modelo);

            //Guardar el vehículo en la base de datos
            Datos.GuardarVehiculo(vehicleData);
        }

        public void agregarNuevoPagoInfraccion(PagoInfraccion pagoInf)
        {
            pagosInfracciones.Add(pagoInf);

            Vehiculo vehiculo = pagoInf.ObtenerVehiculo;
            vehiculo.agregarInfraccion(pagoInf);

            Datos.GuardarPagoInfraccion(pagoInf.desarmar());
        }

        public void modificarTipoInfraccion(Infraccion infraccion)
        {
            var existente = infracciones.FirstOrDefault(i => i.Codigo == infraccion.Codigo);
            if (existente != null)
            {
                existente.Nombre = infraccion.Nombre;
                existente.Descripcion = infraccion.Descripcion;
                existente.Importe = infraccion.Importe;

                ArrayList dataInfraccion = infraccion.desarmar();
                Datos.updateDataTipoInfraccion(dataInfraccion);
            }
            else
            {
                throw new Exception("Infracción no encontrada");
            }
        }

        public void eliminarTipoInfraccion(Infraccion infraccion)
        {
            infracciones.Remove(infraccion);

            Datos.eliminarTipoInfraccion(infraccion.Codigo);

            for (int i = pagosInfracciones.Count - 1; i >= 0; i--)
            {
                PagoInfraccion pagoInfraccion = pagosInfracciones[i];

                if (pagoInfraccion.ObtenerInfraccion == infraccion)
                {
                    pagoInfraccion.ObtenerVehiculo.eliminarInfraccion(pagoInfraccion);
                    pagosInfracciones.RemoveAt(i);
                }
            }
        }

        public void eliminarPagoInfraccion(PagoInfraccion pagoInfraccion)
        {
            pagosInfracciones.Remove(pagoInfraccion);
            pagoInfraccion.ObtenerVehiculo.eliminarInfraccion(pagoInfraccion);
        }

        //Obtener info de DB:
        public void setConnectionDBPath(string path)
        {
            //Originalmente va a traer un directorio del tipo ->    C:\Users\NICOLE\source\repos\SistemaInfracciones\CapaUsuario\bin\Debug
            //esto se debe a que toma la direccion donde se esta ejecutando, en este caso, capa usuario.
            //hay que acomodarlo para llegar a la capa de datos->   C:\Users\NICOLE\source\repos\SistemaInfracciones\CapaDatos

            string originalPath = path; //hago una copia de la direccion original para adaptarla

            // Parent = te mueve a una carpeta padre, al usarla una vez nos vemos a /CapaUsuario y con la segunda a /SistemaInfracciones
            string projectRoot = Directory.GetParent(originalPath).Parent.Parent.FullName; //de esta manera estoy parado en SistemaInfracciones

            // Ahora, estando en SistemaInfracciones busco una carpeta llamada "CapaDatos"
            string newPath = Path.Combine(projectRoot, "CapaDatos"); //de esta manera estoy parado donde temenemos la BBDD.

            Datos.setConnectionDBPath(newPath);
        }

        public void getDataFromDB()
        {
            this.RecuperarVehiculoDB();
            this.RecuperarInfraccionDB();
            this.RecuperarPagoInfraccionDB();
        }

        //RECUPERAR VEHICULO
        public bool RecuperarVehiculoDB()
        {
            List<ArrayList> recuperarVehiculosDB = new List<ArrayList>();
            if (Datos.RecuperarVehiculoDB(recuperarVehiculosDB))
            {

                foreach (ArrayList v in recuperarVehiculosDB)
                {
                    //string id = v[1].ToString();
                    string dominio = v[1].ToString();
                    string dniPropietario = v[2].ToString();
                    string modelo = v[3].ToString();

                    Vehiculo veh = new Vehiculo(dominio, dniPropietario, modelo);

                    //Agregar vehiculos al arrayList de la Administradora
                    this.vehiculos.Add(veh);
                }
                return true;
            }
            else
            {
                //Error al realizar la consulta en la base de datos
                return false;
            }

        }

        //RECUPERAR INFRACCION
        public bool RecuperarInfraccionDB()
        {
            List<ArrayList> recuperarInfraccionesDB = new List<ArrayList>();
            if (Datos.RecuperarInfraccionDB(recuperarInfraccionesDB))
            {

                foreach (ArrayList i in recuperarInfraccionesDB)
                {
                    //string id = i[0].ToString();
                    string codigo = i[1].ToString();
                    string nombre = i[2].ToString();
                    string descripcion = i[3].ToString();
                    decimal importe = Convert.ToDecimal(i[4]);
                    string tipo = i[5].ToString(); // "Grave" o "Leve"

                    Infraccion inf;
                    if (tipo == "Grave")
                    {
                        inf = new InfraccionGrave(codigo, nombre, descripcion, importe);
                    }
                    else
                    {
                        inf = new InfraccionLeve(codigo, nombre, descripcion, importe);
                    }

                    // Agregar la infracción a la lista
                    this.infracciones.Add(inf);
                }
                return true;
            }
            else
            {
                //Error al realizar la consulta en la base de datos
                return false;
            }
        }
          

        //RECUPERAR PAGOS INFRACCIONES  
        public bool RecuperarPagoInfraccionDB()
        {
            List<ArrayList> recuperarPagosDB = new List<ArrayList>();
            if (Datos.RecuperarPagoInfraccionDB(recuperarPagosDB))
            {
                foreach (ArrayList p in recuperarPagosDB)
                {
                    int id = Convert.ToInt16(p[0]);
                    string codigoInfraccion = Datos.getCodigoInfraccionDB(p[1].ToString()).ToString();
                    string dominioVehiculo = Datos.getDominioVehiculoDB(p[2].ToString()).ToString();
                    DateTime fechaInfraccion = Convert.ToDateTime(p[3]);
                    decimal importePagado = Convert.ToDecimal(p[4]);
                    bool pagoCompletado = Convert.ToBoolean(p[5]);

                    //Se obtiene la infracción y vehículo correspondientes
                    Infraccion infraccion = this.getInfraccion(codigoInfraccion);
                    Vehiculo vehiculo = this.getVehiculo(dominioVehiculo);

                    //Se crea la instancia del pago
                    PagoInfraccion pago = new PagoInfraccion(id, infraccion, vehiculo, fechaInfraccion);

                    if(importePagado != 0)
                    {
                        pago.agregarPago(importePagado);
                    }

                    pagosInfracciones.Add(pago);

                    vehiculo.agregarInfraccion(pago);
                }
                return true;
            }
            else
                return false;
        }
    }

}



