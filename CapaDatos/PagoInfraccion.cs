//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_de_Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagoInfraccion
    {
        public int idPagoInfraccion { get; set; }
        public int idInfraccion { get; set; }
        public int idVehiculo { get; set; }
        public System.DateTime fechaInfraccion { get; set; }
        public decimal importePago { get; set; }
        public bool pagoCompleto { get; set; }
    
        public virtual Infraccion Infraccion { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
