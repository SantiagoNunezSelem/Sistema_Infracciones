using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

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

            //Hardcodeado
            InfraccionGrave infra = new InfraccionGrave("1","Mal Estacionamiento","soy una descripcion",5000);
            infracciones.Add(infra);
            InfraccionLeve infra2 = new InfraccionLeve("2", "Exceso de Velocidad", "soy otra descripcion", 10000);
            infracciones.Add(infra2);

            Vehiculo vehiculo = new Vehiculo("111","11111111","modelo1");
            vehiculos.Add(vehiculo);
        }

        public static Administradora getInstanciaAdministradora()
        {
            if(instancia == null)
            {
                Administradora adm = new Administradora();
                instancia = adm;
            }
            return instancia;
        }

        public void agregarTipoInfraccion(Infraccion inf)
        {
            infracciones.Add(inf);
        }

        public void nuevoPagoInfraccion(PagoInfraccion pagoInf)
        {
            pagosInfracciones.Add(pagoInf);
        }

        public List<Infraccion> getInfracciones()
        {
            return infracciones;
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

        static void Main()
        {
        }



    }
}
