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
