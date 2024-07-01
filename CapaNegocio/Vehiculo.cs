using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vehiculo
    {
        private string dominio;
        private string dniPropietario;
        private string modelo;
        private List<PagoInfraccion> pagosInfracciones;

        public Vehiculo(string dominio, string dniPropietario, string modelo)
        {
            this.dominio = dominio;
            this.dniPropietario = dniPropietario;
            this.modelo = modelo;
        }

        public bool esVehiculo(string dominio)
        {
            return (this.dominio.Equals(dominio));
        }

        public List<PagoInfraccion> getPagosInfraccionesPendientes()
        {
            List<PagoInfraccion> pagosInfraccionesPendientes = new List<PagoInfraccion>();

            for(int i=0;i < pagosInfracciones.Count;i++)
            {
                if (pagosInfracciones[i].estadoPagoPendiente())
                    pagosInfraccionesPendientes.Add(pagosInfracciones[i]);
            }
            
            return pagosInfraccionesPendientes;
        }

        public List<PagoInfraccion> getPagosInfraccionesConcretadas()
        {
            List<PagoInfraccion> pagosInfraccionesConcretadas = new List<PagoInfraccion>();

            for (int i = 0; i < pagosInfracciones.Count; i++)
            {
                if (pagosInfracciones[i].estadoPagoConcretado())
                    pagosInfraccionesConcretadas.Add(pagosInfracciones[i]);
            }

            return pagosInfraccionesConcretadas;
        }

        public List<PagoInfraccion> getPagosInfraccionesVencidas()
        {
            List<PagoInfraccion> pagosInfraccionesVencidas = new List<PagoInfraccion>();

            for (int i = 0; i < pagosInfracciones.Count; i++)
            {
                if (pagosInfracciones[i].estadoPagoConcretado())
                    pagosInfraccionesVencidas.Add(pagosInfracciones[i]);
            }

            return pagosInfraccionesVencidas;
        }

        public string Dominio
        {
            get { return dominio; }
        }

        public string DniPropietario
        {
            get { return dniPropietario; }
        }

        public string Modelo
        {
            get { return modelo; }
        }
    }
}
