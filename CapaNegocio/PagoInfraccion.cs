using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoInfraccion
    {
        private int id;
        private Infraccion infraccion;
        private Vehiculo vehiculo;
        private DateTime fechaInfraccion;
        private decimal importePagado;
        private bool pagoCompletado; //Si la infraccion se paga por completo y luego un descuento se deshabilita esta variable bool va a indicar que el pago esta finalizado de igual forma

        public PagoInfraccion(int id, Infraccion infraccion, Vehiculo vehiculo, DateTime fechaInfraccion)
        {
            this.id = id;
            this.infraccion = infraccion;
            this.vehiculo = vehiculo;
            this.fechaInfraccion = fechaInfraccion;
            pagoCompletado = false;
        }

        public List<string> desarmar()
        {
            List<string> data = new List<string>();
            data.Add(infraccion.Codigo);
            data.Add(vehiculo.Dominio);
            data.Add(fechaInfraccion.ToString());
            data.Add(importePagado.ToString());
            data.Add(pagoCompletado.ToString());

            return data;
        }

        public bool fechaPagoVencida()
        {
            int a = fechaInfraccion.AddMonths(1).CompareTo(DateTime.Now);
            if (a < 0)
                return true;
            else
                return false;
        }

        public DateTime getFechaVencimiento()
        {
            return fechaInfraccion.AddMonths(1);
        }

        public decimal getImportePendienteInfraccion()
        {
            if (pagoCompletado)
            {
                return 0;
            }
            else
            {
                return getImporteInfraccion() - importePagado;
            }
        }
        public decimal getImporteInfraccion()
        {
            return infraccion.getImporteInfraccionConDescuento(fechaInfraccion.AddMonths(1));
        }

        public void agregarPago(decimal pago)
        {
            importePagado += pago;

            if(getImportePendienteInfraccion() == 0)
            {
                this.pagoCompletado = true;
            }
        }

        public bool pagoCompleto()
        {
            return this.pagoCompletado;
        }

        public bool estadoPagoPendiente()
        {
            
            if (!pagoCompleto() && !fechaPagoVencida())
                return true;
            else
                return false;
        }

        public bool estadoPagoConcretado()
        {

            if (pagoCompleto())
                return true;
            else
                return false;
        }

        public bool estadoPagoVencido()
        {
            if (!pagoCompleto() && fechaPagoVencida())
                return true;
            else
                return false;
        }

        public int Id
        {
            get { return id; }
        }

        public Infraccion ObtenerInfraccion
        {
            get { return  infraccion; }
        }
        public Vehiculo ObtenerVehiculo
        {
            get { return vehiculo; }
        }
        /* Se utiliza en los listbox (displayMember) para mostrar informacion */
        public string DisplayTextPagoPendiente
        {
            get
            {
                return " " + fechaInfraccion.ToShortDateString() + "  -  Pendiente: $" + getImportePendienteInfraccion();
            }
        }

        public string DisplayTextPagoConcretado
        {
            get
            {
                return " " + fechaInfraccion.ToShortDateString() + "  -  Pago: $" + importePagado;
            }
        }

        public string DisplayTextPagoVencido
        {
            get
            {
                return " " + fechaInfraccion.ToShortDateString() + "  -  Pendiente: $" + getImportePendienteInfraccion();
            }
        }
    }
}
