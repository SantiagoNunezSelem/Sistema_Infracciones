using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Administradora
    {
        private static Administradora instancia;
        private List<Infraccion> infracciones;

        public Administradora()
        {
            infracciones = new List<Infraccion>();

            //Hardcodeado
            InfraccionGrave infra = new InfraccionGrave(1,"Mal Estacionamiento","soy una descripcion",5000);
            infracciones.Add(infra);
        }

        public static Administradora getInstanciaAdministradora()
        {
            if(instancia == null)
            {
                Administradora adm = new Administradora();
                instancia = adm;
            }
            return instancia;
        }

        public Infraccion getInfraccion()
        {
            return infracciones.FirstOrDefault();
        }

        static void Main()
        {
        }



    }
}
