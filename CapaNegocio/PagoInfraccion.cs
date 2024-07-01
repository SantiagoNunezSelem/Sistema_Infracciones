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
    }
}
