using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaNegocio;

namespace Sistema_Infracciones
{
    public partial class InformacionPagos : MaterialForm
    {
        private Administradora adm = new Administradora();
        private Vehiculo vehiculoSeleccionado;
        public InformacionPagos()
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
        
        private void InformacionPagos_Load(object sender, EventArgs e)
        {
            labelModeloVehiculo.Text = "Modelo Vehículo";
            labelDniPropietario.Text = "DNI Propietario";
            infoBusquedaDominioVehiculo.Text = "";
        }

        private void inputDominioVehiculo_TextChanged(object sender, EventArgs e)
        {
            string dominio = inputDominioVehiculo.Text;
            if (dominio != "")
            {
                Vehiculo buscarVehiculo = adm.getVehiculo(dominio);

                if (buscarVehiculo != null)
                {
                    infoBusquedaDominioVehiculo.Text = "Encontrado";
                    labelModeloVehiculo.Text = buscarVehiculo.Modelo;
                    labelDniPropietario.Text = buscarVehiculo.DniPropietario;
                    this.vehiculoSeleccionado = buscarVehiculo;

                    getInfoPagos(dominio);
                }
                else
                {
                    infoBusquedaDominioVehiculo.Text = "No existe";
                    this.vehiculoSeleccionado = null;
                }
            }
            else
            {
                this.vehiculoSeleccionado = null;
                infoBusquedaDominioVehiculo.Text = "";
            }
        }

        public void getInfoPagos(string dominio)
        {

        }
    }
}
