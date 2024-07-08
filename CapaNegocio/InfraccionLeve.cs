﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    public class InfraccionLeve : Infraccion
    {

        private const double porcentaje_descuento20 = 10 / 100;
        private const double porcentaje_descuento10 = 15 / 100;

        public InfraccionLeve(string codigo, string nombre, string descripcion, decimal importe) :
            base(codigo, nombre, descripcion, importe)
        {
        }

        public override bool esInfraccionLeve()
        {
            return true;
        }
        public override bool esInfraccionGrave()
        {
            return false;
        }

        public override double dameDescuento(DateTime fechaVencimiento)
        {
            double result = 0;

            var diff = (fechaVencimiento - DateTime.Today).TotalDays;

            if (diff >= 20)
            {
                result = porcentaje_descuento20;
            }
            else if (diff >= 10)
            {
                result = porcentaje_descuento10;
            }

            return result;
        }

        public override void armar(ArrayList l)
        {
            base.armar(l);
        }

        public override ArrayList desarmar()
        {
            ArrayList l = new ArrayList();

            l.Add(codigo);
            l.Add(nombre);
            l.Add(descripcion);
            l.Add(importe);

            return l;
        }


    }
}
