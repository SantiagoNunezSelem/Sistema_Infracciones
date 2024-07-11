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
using CapaNegocio;


namespace Sistema_Infracciones
{
    public partial class Index : MaterialForm
    {
        public Index()
        {
            InitializeComponent();

            Administradora adm = new Administradora();

            this.Width = 1000;
            this.Height = 550;

            this.StartPosition = FormStartPosition.CenterScreen;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void agregarTipoInfraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarInfraccionVehiculo agregarInfraccionVehiculo = new AgregarInfraccionVehiculo();
            agregarInfraccionVehiculo.ShowDialog();
        }

        private void informacionPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionPagos infoPagos = new InformacionPagos();
            infoPagos.ShowDialog();
        }

        private void registrarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVehiculo agregarVehiculo = new AgregarVehiculo();
            agregarVehiculo .ShowDialog();
        }
    }
}
