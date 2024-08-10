using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaNegocio
{
    public class InfraccionLeve : Infraccion
    {

        private const decimal porcentaje_descuento_20dias = 1-(25m / 100m);
        private const decimal porcentaje_descuento_10dias = 1-(15m / 100m);

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

        public override decimal getDescuento(DateTime fechaVencimiento)
        {
            var diff = (fechaVencimiento - DateTime.Today).TotalDays;

            if (diff >= 20)
            {
                return porcentaje_descuento_20dias;
            }
            if (diff >= 10)
            {
                return porcentaje_descuento_10dias;
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
