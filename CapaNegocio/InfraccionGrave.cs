using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class InfraccionGrave : Infraccion
    {
        public InfraccionGrave(int codigo, string nombre, string descripcion, decimal importe) :
           base(codigo, nombre,descripcion, importe)
        {
        }

        public override bool esInfraccionLeve()
        {
            return false;
        }

        public override bool esInfraccionGrave()
        {
            return true;
        }

    }
}
