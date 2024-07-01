using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class InfraccionGrave : Infraccion
    {
        public InfraccionGrave(string codigo, string nombre, string descripcion, decimal importe) :
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
