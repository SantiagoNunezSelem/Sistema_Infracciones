﻿using System;
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
        public List<Vehiculo> getVehiclesByOwner(string ownerDni) {
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
                    infraData.Add("grave");
                }
                else
                {
                    infraData.Add("leve");
                }
                //Guardar la infraccion en la base de datos
                Datos.guardarInfraccionDB(infraData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la infracción: " + ex.Message);
            }
        }

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);

            List<string> vehiculoData = new List<string>();
            vehiculoData.Add(vehiculo.Dominio);
            vehiculoData.Add(vehiculo.DniPropietario);
            vehiculoData.Add(vehiculo.Modelo);

            //Guardar el vehículo en la base de datos
            Datos.guardarVehiculoDB(vehiculoData);
        }

        public void agregarNuevoPagoInfraccion(PagoInfraccion pagoInf)
        {
            pagosInfracciones.Add(pagoInf);

            Vehiculo vehiculo = pagoInf.ObtenerVehiculo;
            vehiculo.agregarInfraccion(pagoInf);

            Datos.guardarPagoInfraccionDB(pagoInf.desarmar());
        }

        public void registrarElPagoDeInfraccion(PagoInfraccion pagoInf, decimal importePagado)
        {
            pagoInf.agregarPago(importePagado);

            Datos.updatePagoInfraccion(pagoInf.desarmar());
        }

        public void modificarTipoInfraccion(Infraccion infraccion)
        {
            List<string> dataInfraccion = infraccion.desarmar();
            var existente = infracciones.FirstOrDefault(i => i.Codigo == infraccion.Codigo);
            if (existente != null)
            {
                existente.Nombre = infraccion.Nombre;
                existente.Descripcion = infraccion.Descripcion;
                existente.Importe = infraccion.Importe;

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

            Datos.eliminarPagoInfraccion(pagoInfraccion.Id.ToString());
        }

        public bool tryConnectionDB(ref string errorMessage)
        {
            Exception error = Datos.tryConnectionDB();
            if (error == null)
            {
                return true;
            }
            else
            {
                errorMessage = error.Message;
                return false;
            }
        }

        public void getDataFromDB()
        {
            this.recuperarVehiculosDB();
            this.RecuperarInfraccionDB();
            this.RecuperarPagoInfraccionDB();
        }

        //RECUPERAR VEHICULO
        public bool recuperarVehiculosDB()
        {
            var recuperarVehiculosDB = Datos.recuperarVehiculosDB();

            if (recuperarVehiculosDB != null)
            {

                foreach (var vehiculo in recuperarVehiculosDB)
                {
                    //string id = vehiculo[1].ToString();
                    string dominio = vehiculo.dominio;
                    string dniPropietario = vehiculo.dniPropietario;
                    string modelo = vehiculo.modelo;

                    Vehiculo newVehiculo = new Vehiculo(dominio, dniPropietario, modelo);

                    //Agregar vehiculos al arrayList de la Administradora
                    this.vehiculos.Add(newVehiculo);
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        //RECUPERAR INFRACCION
        public bool RecuperarInfraccionDB()
        {
            var recuperarInfraccionesDB = Datos.recuperarInfraccionesDB();

            if (recuperarInfraccionesDB != null)
            {
                foreach (var infraccion in recuperarInfraccionesDB)
                {
                    //string id = i[0].ToString();
                    string codigo = infraccion.codigo;
                    string nombre = infraccion.nombre;
                    string descripcion = infraccion.descripcion;
                    decimal importe = infraccion.importe;
                    string tipo = infraccion.tipo; // "Grave" o "Leve"

                    Infraccion inf;
                    if (tipo == "grave")
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
                return false;
            }
        }

        //RECUPERAR PAGOS INFRACCIONES  
        public bool RecuperarPagoInfraccionDB()
        {
            var recuperarPagosDB = Datos.recuperarPagoInfraccionesDB();
            if (recuperarPagosDB != null)
            {
                foreach(var pInf in recuperarPagosDB)
                {
                    int id = pInf.idPagoInfraccion;

                    string codigoInfraccion = Datos.buscarInfraccionConIdDB(pInf.idInfraccion).codigo;

                    string dominioVehiculo = Datos.buscarVehiculoConIdDB(pInf.idVehiculo).dominio;

                    DateTime fechaInfraccion = pInf.fechaInfraccion;
                    decimal importePago = pInf.importePago;
                    bool pagoCompletado = pInf.pagoCompleto;

                    //Se obtiene la infracción y vehículo correspondientes
                    Infraccion infraccion = this.getInfraccion(codigoInfraccion);
                    Vehiculo vehiculo = this.getVehiculo(dominioVehiculo);

                    //Se crea la instancia del pago
                    PagoInfraccion pago = new PagoInfraccion(id, infraccion, vehiculo, fechaInfraccion, pagoCompletado);

                    if(importePago != 0)
                    {
                        pago.agregarPago(importePago);
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



