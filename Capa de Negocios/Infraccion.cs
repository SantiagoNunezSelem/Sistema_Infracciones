using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal abstract class Infraccion
    {
        protected int codigo;
        protected string nombre;
        protected string descripcion;
        protected decimal importe;

        public Infraccion(int codigo,string nombre, string descripcion, decimal importe)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.importe = importe;
        }

        public abstract bool esInfraccionLeve();

        public abstract bool esInfraccionGrave();
    }
}
