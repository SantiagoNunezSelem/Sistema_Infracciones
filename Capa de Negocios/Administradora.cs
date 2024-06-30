using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    internal class Administradora
    {
        private List<Infraccion> infracciones;

        public Administradora()
        {
            infracciones = new List<Infraccion>();

            //Hardcodeado
            InfraccionGrave infra = new InfraccionGrave(1,"mal estacionamiento","soy una descripcion",5000);
            infracciones.Add(infra);
        }


        
    }
}
