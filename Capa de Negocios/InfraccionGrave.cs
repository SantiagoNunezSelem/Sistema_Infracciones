using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Negocios
{
    internal class InfraccionGrave : Infraccion
    {
        public InfraccionGrave(int codigo, string descripcion, decimal importe) :
           base(codigo, descripcion, importe)
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
