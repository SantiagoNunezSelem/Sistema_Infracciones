using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class PagoInfraccion
    {
        private Infraccion tipoInfraccion;
        private Vehiculo vehiculo;
        private DateTime fechaInfraccion;
        private decimal importePagado;

        public PagoInfraccion(Infraccion tipoInfraccion, Vehiculo vehiculo, DateTime fechaInfraccion, decimal importePagado)
        {
            this.tipoInfraccion = tipoInfraccion;
            this.vehiculo = vehiculo;
            this.fechaInfraccion = fechaInfraccion;
            this.importePagado = importePagado;
        }
    }
}
