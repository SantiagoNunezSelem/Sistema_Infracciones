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
            materialComboBox1.Items.Add(adm.getInfraccion().getCodigo());

            labelNombre.Text = "Nombre Infraccion";
            labelModeloVehiculo.Text = "Modelo Vehículo";
            labelDniPropietario.Text = "DNI Propietario";
            labelDescInfraccion.Text = "Descripción";
            labelImporte.Text = "Importe";
            labelGravedadInfraccion.Text = "Gravedad de Infraccion";
            
        }

        
    }
}
