using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Infraccion
    {
        protected string codigo;
        protected string nombre;
        protected string descripcion;
        protected decimal importe;

        public Infraccion(string codigo,string nombre, string descripcion, decimal importe)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.importe = importe;
        }

        public abstract bool esInfraccionLeve();

        public abstract bool esInfraccionGrave();


        public bool esInfraccion(string codigo)
        {
            return (this.codigo.Equals(codigo));
        }
        public string Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Descripcion
        {
            get { return descripcion; }
        }

        public decimal Importe
        {
            get { return importe; }
        }
    }
}
