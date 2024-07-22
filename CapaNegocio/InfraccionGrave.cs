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
           base(codigo, nombre,descripcion, importe, true) // Grave es true para EsGrave

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
