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
        Administradora adm = Administradora.getInstanciaAdministradora();
        public Index()
        {
            InitializeComponent();

            this.getDataFromDB();

            this.Width = 1000;
            this.Height = 550;

            this.StartPosition = FormStartPosition.CenterScreen;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void getDataFromDB()
        {
            adm.setConnectionDBPath(Application.StartupPath);
            adm.getDataFromDB();
        }

        //DE INFRACCION
        private void PagarInfraccionVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoInfraccionVehiculo pagoInfraccionVehiculo = new PagoInfraccionVehiculo();
            pagoInfraccionVehiculo.ShowDialog();
        }

        private void AgregarInfraccionVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarInfraccionVehiculo agregarInfraccionVehiculo = new AgregarInfraccionVehiculo();
            agregarInfraccionVehiculo.ShowDialog();
        }

        private void nuevoTipoInfraccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarNuevoTipoInfraccion nuevoTipoInfraccion = new AgregarNuevoTipoInfraccion();
            nuevoTipoInfraccion.ShowDialog();
        }

        private void EditarTipoInfracciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditarTipoInfraccion editarTipoInfraccion = new EditarTipoInfraccion();
            editarTipoInfraccion.ShowDialog();
        }

        private void BorrarTipoInfracciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTipoInfraccion eliminarTipoInfraccion = new EliminarTipoInfraccion();
            eliminarTipoInfraccion.ShowDialog();
        }

        //DE PAGOS
        private void informacionPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionPagos infoPagos = new InformacionPagos();
            infoPagos.ShowDialog();
        }

        //DE VEHICULOS
        private void registrarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarVehiculo agregarVehiculo = new AgregarVehiculo();
            agregarVehiculo.ShowDialog();
        }
    }
}
