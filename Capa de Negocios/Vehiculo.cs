using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class Vehiculo
    {
        private int dominio;
        private int dniPropietario;
        private string modelo;

        public Vehiculo(int dominio, int dniPropietario, string modelo)
        {
            this.dominio = dominio;
            this.dniPropietario = dniPropietario;
            this.modelo = modelo;
        }
    }
}
