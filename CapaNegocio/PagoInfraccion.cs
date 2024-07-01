using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoInfraccion
    {
        private Infraccion infraccion;
        private Vehiculo vehiculo;
        private DateTime fechaInfraccion;
        private decimal importePagado;

        public PagoInfraccion(Infraccion infraccion, Vehiculo vehiculo, DateTime fechaInfraccion, decimal importePagado)
        {
            this.infraccion = infraccion;
            this.vehiculo = vehiculo;
            this.fechaInfraccion = fechaInfraccion;
            this.importePagado = importePagado;
        }

        public bool fechaPagoVencida()
        {
            int a = fechaInfraccion.AddMonths(1).CompareTo(DateTime.Now);
            if (a > 0)
                return true;
            else
                return false;
        }

        public bool pagoCompleto()
        {
            if (this.importePagado == infraccion.Importe)
                return true;
            else
                return false;
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
            if (fechaPagoVencida())
                return true;
            else
                return false;
        }
    }
}
