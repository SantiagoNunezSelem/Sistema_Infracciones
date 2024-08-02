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

        public static List<Vehiculo> recuperarVehiculosDB()
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

        public static List<Infraccion> recuperarInfraccionesDB()
        {
            try
            {
                using (var context = new Datos())
                {
                    return context.Infracciones.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static List<PagoInfraccion> recuperarPagoInfraccionesDB()
        {
            try
            {
                using (var context = new Datos())
                {
                    return context.PagoInfracciones.ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool guardarVehiculoDB(List<string> vehiculoData)
        {
            try
            {
                using (var context = new Datos())
                {
                    Vehiculo addVehiculo = new Vehiculo {
                        dominio = vehiculoData[0],
                        dniPropietario = vehiculoData[1],
                        modelo = vehiculoData[2]
                    };

                    context.Vehiculos.Add(addVehiculo);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool guardarInfraccionDB(List<string> infraccionData)
        {
            try
            {
                using (var context = new Datos())
                {
                    Infraccion addInfraccion = new Infraccion
                    {
                        codigo = infraccionData[0],
                        nombre = infraccionData[1],
                        descripcion = infraccionData[2],
                        importe = decimal.Parse(infraccionData[3]),
                        tipo = infraccionData[4]
                    };

                    context.Infracciones.Add(addInfraccion);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}



