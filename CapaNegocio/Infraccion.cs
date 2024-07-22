using System;
using System.Collections;
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
        protected bool esGrave;

        public Infraccion(string codigo,string nombre, string descripcion, decimal importe, bool esGrave)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.importe = importe;
            this.esGrave = esGrave;
        }

        public abstract bool esInfraccionLeve();

        public abstract bool esInfraccionGrave();

        public virtual void armar(ArrayList l)
        {
            this.codigo = l[0].ToString();
            this.nombre = l[1].ToString();
            this.descripcion = l[2].ToString();
            this.importe = decimal.Parse(l[3].ToString());
        }

        public abstract ArrayList desarmar();

        public bool esInfraccion(string codigo)
        {
            return (this.codigo.Equals(codigo));
        }

        public abstract decimal getDescuento(DateTime fechaVencimiento);

        public decimal getImporteInfraccionConDescuento(DateTime fechaVencimientoInfraccion)
        {
            return importe * getDescuento(fechaVencimientoInfraccion);
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; } 
        }


        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public bool EsGrave
        {
            get { return esGrave; }
            set { esGrave = value; }
        }


        //Validar sos 
        public bool sos(string unCod)
        {
            return codigo.Equals(unCod);
        }



    }



}
