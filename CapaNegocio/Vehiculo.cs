﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Vehiculo
    {
        private string dominio; // patente
        private string dniPropietario;
        private string modelo;
        private List<PagoInfraccion> pagosInfracciones;

        public Vehiculo(string dominio, string dniPropietario, string modelo)
        {
            this.dominio = dominio;
            this.dniPropietario = dniPropietario;
            this.modelo = modelo;
            pagosInfracciones = new List<PagoInfraccion>();
        }

        public bool esVehiculo(string dominio)
        {
            return (this.dominio.Equals(dominio));
        }

        public List<PagoInfraccion> getPagosInfraccionesPendientes()
        {
            List<PagoInfraccion> pagosInfraccionesPendientes = new List<PagoInfraccion>();
            if (pagosInfracciones != null)
            {
                for (int i = 0; i < pagosInfracciones.Count; i++)
                {
                    if (pagosInfracciones[i].estadoPagoPendiente())
                        pagosInfraccionesPendientes.Add(pagosInfracciones[i]);
                }

                return pagosInfraccionesPendientes;
            }
            return null;
        }

        public List<PagoInfraccion> getPagosInfraccionesConcretadas()
        {
            List<PagoInfraccion> pagosInfraccionesConcretadas = new List<PagoInfraccion>();

            if (pagosInfracciones != null)
            {
                for (int i = 0; i < pagosInfracciones.Count; i++)
                {
                    if (pagosInfracciones[i].estadoPagoConcretado())
                        pagosInfraccionesConcretadas.Add(pagosInfracciones[i]);
                }

                return pagosInfraccionesConcretadas;
            }
            return null;
        }

        public List<PagoInfraccion> getPagosInfraccionesVencidas()
        {
            List<PagoInfraccion> pagosInfraccionesVencidas = new List<PagoInfraccion>();

            if(pagosInfracciones != null)
            {
                for (int i = 0; i < pagosInfracciones.Count; i++)
                {
                    if (pagosInfracciones[i].estadoPagoVencido())
                        pagosInfraccionesVencidas.Add(pagosInfracciones[i]);
                }

                return pagosInfraccionesVencidas;
            }
            return null;
        }

        public List<PagoInfraccion> getPagos()
        {
            List<PagoInfraccion> todosLosPagos = new List<PagoInfraccion>();

            List<PagoInfraccion> pagosPendientes = getPagosInfraccionesPendientes();
            List<PagoInfraccion> pagosConcretados = getPagosInfraccionesConcretadas();
            List<PagoInfraccion> pagosVencidos = getPagosInfraccionesVencidas();

            if (pagosPendientes != null)
            {
                todosLosPagos.AddRange(pagosPendientes);
            }

            if (pagosConcretados != null)
            {
                todosLosPagos.AddRange(pagosConcretados);
            }

            if (pagosVencidos != null)
            {
                todosLosPagos.AddRange(pagosVencidos);
            }

            return todosLosPagos;
        }


        public void agregarInfraccion(PagoInfraccion pagoInfraccion)
        {
            pagosInfracciones.Add(pagoInfraccion);
        }

        public void eliminarInfraccion(PagoInfraccion pagoInfraccion)
        {
            pagosInfracciones.Remove(pagoInfraccion);
        }

        public string Dominio
        {
            get { return dominio; }
        }

        public string DniPropietario
        {
            get { return dniPropietario; }
        }

        public string Modelo
        {
            get { return modelo; }
        }

        public bool sosVehiculo(string dominio)
        {
            return Dominio == dominio;
        }
    }

}

