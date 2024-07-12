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
        private Administradora adm = Administradora.getInstanciaAdministradora();
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

        private void inputDominioVehiculo_TextChanged(object sender, EventArgs e)
        {
            string dominio = inputDominioVehiculo.Text;
            
            Vehiculo buscarVehiculo = adm.getVehiculo(dominio);

            if (buscarVehiculo != null)
            {
                infoBusquedaDominioVehiculo.Text = "Encontrado";
                inputModeloVehiculo.Text = buscarVehiculo.Modelo;
                inputDNIPropietario.Text = buscarVehiculo.DniPropietario;
                this.vehiculoSeleccionado = buscarVehiculo;

                getInfoPagos(dominio);
            }
            else
            {
                listBoxPagosConcretados.Items.Clear();
                listBoxPagosPendientes.Items.Clear();
                listBoxPagosVencidos.Items.Clear();
                infoBusquedaDominioVehiculo.Text = "No existe";
                inputModeloVehiculo.Text = "";
                inputDNIPropietario.Text = "";
                this.vehiculoSeleccionado = null;
            }

            if(dominio == "")
            {
                this.vehiculoSeleccionado = null;
                infoBusquedaDominioVehiculo.Text = "";
            }
        }

        public void getInfoPagos(string dominio)
        {
            List<PagoInfraccion> pagosPendientes = vehiculoSeleccionado.getPagosInfraccionesPendientes();
            if (pagosPendientes != null)
            {
                if (pagosPendientes.Count == 0)
                    listBoxPagosPendientes.Items.Add("-- No tiene Pagos Pendientes --");
                else
                {
                    listBoxPagosPendientes.DataSource = pagosPendientes;
                    listBoxPagosPendientes.DisplayMember = "DisplayTextPagoPendiente";
                }
            }

            List<PagoInfraccion> pagosConcretados = vehiculoSeleccionado.getPagosInfraccionesConcretadas();
            if (pagosConcretados != null)
            {
                if (pagosConcretados.Count == 0)
                    listBoxPagosConcretados.Items.Add("-- No tiene Pagos Concretados --");
                else
                {
                    listBoxPagosConcretados.DataSource = pagosConcretados;
                    listBoxPagosConcretados.DisplayMember = "DisplayTextPagoConcretado";
                }
            }

            List<PagoInfraccion> pagosVencidos = vehiculoSeleccionado.getPagosInfraccionesVencidas();
            if (pagosVencidos != null)
            {
                if (pagosVencidos.Count == 0)
                    listBoxPagosVencidos.Items.Add("-- No tiene Pagos Vencidos --");
                else
                {
                    listBoxPagosVencidos.DataSource = pagosVencidos;
                    listBoxPagosVencidos.DisplayMember = "DisplayTextPagoVencido";
                }
            }
        }
    }
}
