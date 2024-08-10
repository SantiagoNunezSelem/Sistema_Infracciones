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
        private const decimal porcentaje_descuento_25dias = 1-(20m / 100m);

        public InfraccionGrave(string codigo, string nombre, string descripcion, decimal importe) :
           base(codigo, nombre, descripcion, importe)
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

        public override decimal getDescuento(DateTime fechaVencimiento)
        {
            var diff = (fechaVencimiento - DateTime.Today).TotalDays;

            if (diff >= 25)
            {
                return porcentaje_descuento_25dias;
            }

            return 1;
        }

        public override void armar(ArrayList l)
        {
            base.armar(l);
        }

        public override List<string> desarmar()
        {
            List<string> l = new List<string>();

            l.Add(codigo);
            l.Add(nombre);
            l.Add(descripcion);
            l.Add(importe.ToString());

            return l;
        }
    }
}
