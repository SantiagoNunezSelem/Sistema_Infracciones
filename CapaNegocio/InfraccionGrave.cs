using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class InfraccionGrave : Infraccion
    {
        private const double porcentaje_descuento_25dias = 20 / 100;

        public InfraccionGrave(string codigo, string nombre, string descripcion, decimal importe) :
           base(codigo, nombre,descripcion, importe)
        {
        }

        public override bool esInfraccionLeve()
        {
            return false;
        }

        public override bool esInfraccionGrave()
        {
            return true;
        }

        public override double getDescuento(DateTime fechaVencimiento)
        {
            double result = 0;

            var diff = (fechaVencimiento - DateTime.Today).TotalDays;

            if (diff >= 25)
            {
                result = porcentaje_descuento_25dias;
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
