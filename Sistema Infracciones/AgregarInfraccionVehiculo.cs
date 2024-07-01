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
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_Infracciones
{
    public partial class AgregarInfraccionVehiculo : MaterialForm
    {
        private Administradora adm = Administradora.getInstanciaAdministradora();
        public AgregarInfraccionVehiculo()
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

        private void AgregarInfraccionVehiculo_Load(object sender, EventArgs e)
        {
            materialComboBox1.Items.Add(adm.getInfraccion().Codigo);

            labelNombre.Text = "Nombre Infraccion";
            labelModeloVehiculo.Text = "Modelo Vehículo";
            labelDniPropietario.Text = "DNI Propietario";
            labelDescInfraccion.Text = "Descripción";
            labelImporte.Text = "Importe";
            labelGravedadInfraccion.Text = "Gravedad de Infraccion";
        }

        private void inputDominioVehiculo_TextChanged(object sender, EventArgs e)
        {

            string dominio = inputDominioVehiculo.Text;
            if(dominio != "")
            {
                Vehiculo buscarVehiculo = adm.getVehiculo(dominio);

                if (buscarVehiculo != null)
                {
                    infoBusquedaDominioVehiculo.Text = "Encontrado";
                    labelModeloVehiculo.Text = buscarVehiculo.Modelo;
                    labelDniPropietario.Text = buscarVehiculo.DniPropietario;
                }
                else
                {
                    infoBusquedaDominioVehiculo.Text = "No existe";
                }
            }
            else
            {
                infoBusquedaDominioVehiculo.Text = "";
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = materialComboBox1.Text;
            Infraccion buscarInfraccion = adm.getInfraccion(codigo);

            if (buscarInfraccion != null)
            {
                labelNombre.Text = buscarInfraccion.Nombre;
                labelDescInfraccion.Text = buscarInfraccion.Descripcion;
                labelImporte.Text = buscarInfraccion.Importe.ToString();
            }
            
        }
    }
}
