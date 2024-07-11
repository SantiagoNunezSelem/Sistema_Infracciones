using CapaNegocio;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Infracciones
{
    public partial class PagoInfraccionVehiculo : MaterialForm
    {
        private Administradora adm = Administradora.getInstanciaAdministradora();
        private Vehiculo vehiculoSeleccionado;
        public PagoInfraccionVehiculo()
        {
            InitializeComponent();

            this.Width = 1000;
            this.Height = 550;

            this.StartPosition = FormStartPosition.CenterScreen;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void inputDominioVehiculo_TextChanged(object sender, EventArgs e)
        {
            string dominio = inputDominioVehiculo.Text;
            if (dominio != "")
            {
                Vehiculo buscarVehiculo = adm.getVehiculo(dominio);

                if (buscarVehiculo != null)
                {
                    inputModeloVehiculo.Text = buscarVehiculo.Modelo;
                    inputDNIPropietario.Text = buscarVehiculo.DniPropietario;
                    this.vehiculoSeleccionado = buscarVehiculo;

                    getInfoPagos(dominio);
                }
                else
                {
                    listBoxPagosPendientes.Items.Clear();
                    inputModeloVehiculo.Text = "";
                    inputDNIPropietario.Text = "";
                    this.vehiculoSeleccionado = null;
                }
            }
            else
            {
                this.vehiculoSeleccionado = null;
            }
        }

        public void getInfoPagos(string dominio)
        {
            List<PagoInfraccion> pagosInfracciones = new List<PagoInfraccion>();

            pagosInfracciones = vehiculoSeleccionado.getPagosInfraccionesPendientes();
            if (pagosInfracciones != null)
            {
                foreach (PagoInfraccion pago in pagosInfracciones)
                {
                    listBoxPagosPendientes.Items.Add(pago);
                }
            }
        }

        private void listBoxPagosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
