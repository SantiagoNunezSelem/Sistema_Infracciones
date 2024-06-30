using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Negocios
{
    internal abstract class Infraccion
    {
        protected int codigo;
        protected string descripcion;
        protected decimal importe;

        public Infraccion(int codigo, string descripcion, decimal importe)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.importe = importe;
        }

        public abstract bool esInfraccionLeve();

        public abstract bool esInfraccionGrave();
    }
}
