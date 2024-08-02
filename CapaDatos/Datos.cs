using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using Capa_de_Datos;
using System.Linq;

namespace Capa_Datos
{
    public class Datos : DbContext
    {
        public Datos()
            : base("name=SistemaInfraccionesDBEntities")
        {
        }

        public DbSet<Infraccion> Infracciones {  get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<PagoInfraccion> PagoInfracciones { get; set; }

        public static List<Vehiculo> recuperarVehiculos()
        {
            try
            {
                using (var context = new Datos())
                {
                    return context.Vehiculos.ToList();
                }
            }
            catch{
                return null;
            }
            
        }
    }
}



