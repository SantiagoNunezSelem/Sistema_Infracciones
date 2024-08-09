﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Data.Entity;
using Capa_de_Datos;
using System.Linq;
using System.CodeDom;

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

        public static Exception tryConnectionDB()
        {
            try
            {
                using (var context = new Datos())
                {
                    context.Vehiculos.ToList();
                    return null;
                }
            }
            catch(Exception ex) 
            {
                return ex;
            }
        }

        //Recuperar Data
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

        //Guardar Data
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

        //Buscar Data
        public static bool guardarPagoInfraccionDB(List<string> pInfData)
        {
            try
            {
                using(var context = new Datos())
                {
                    int idInfraccion = buscarInfraccionConCodigoDB(pInfData[1]).idInfraccion;
                    int idVehiculo = buscarVehiculoConDominio(pInfData[2]).idVehiculo;

                    PagoInfraccion addPInf = new PagoInfraccion
                    {
                        idPagoInfraccion = int.Parse(pInfData[0]),
                        idInfraccion = idInfraccion,
                        idVehiculo = idVehiculo,
                        fechaInfraccion = DateTime.Parse(pInfData[3]),
                        importePago = decimal.Parse(pInfData[4]),
                        pagoCompleto = bool.Parse(pInfData[5])
                    };
                    context.PagoInfracciones.Add(addPInf);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Infraccion buscarInfraccionConIdDB(int id)
        {
            try
            {
                using (var context = new Datos())
                {
                    Infraccion buscarInfraccion = context.Infracciones.Find(id);
                    return buscarInfraccion;
                }
            }
            catch
            {
                return null;
            }
        }

        public static Vehiculo buscarVehiculoConIdDB(int id)
        {
            try
            {
                using (var context = new Datos())
                {
                    Vehiculo buscarVehiculo = context.Vehiculos.Find(id);
                    return buscarVehiculo;
                }
            }
            catch
            {
                return null;
            }
        }
        public static Infraccion buscarInfraccionConCodigoDB(string codigo)
        {
            try
            {
                using (var context = new Datos())
                {
                    Infraccion buscarInfraccion = (from infraccion in context.Infracciones
                                                   where infraccion.codigo == codigo
                                                   select infraccion).FirstOrDefault<Infraccion>();
                    return buscarInfraccion;
                }
            }
            catch
            {
                return null;
            }
        }

        public static Vehiculo buscarVehiculoConDominio(string dominio)
        {
            try
            {
                using (var context = new Datos())
                {
                    Vehiculo buscarVehiculo = (from vehiculo in context.Vehiculos
                                               where vehiculo.dominio == dominio
                                               select vehiculo).FirstOrDefault<Vehiculo>();
                    return buscarVehiculo;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}



