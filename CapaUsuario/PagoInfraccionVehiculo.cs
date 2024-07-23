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
                    listBoxPagosPendientes.DataSource = null;
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

            listBoxPagosPendientes.DataSource = pagosInfracciones;
            listBoxPagosPendientes.DisplayMember = "DisplayTextPagoPendiente";
        }

        private void listBoxPagosPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PagoInfraccion pagoinfraccion = (PagoInfraccion)listBoxPagosPendientes.SelectedItem;
            if (pagoinfraccion != null)
            {
                Infraccion infraccion = pagoinfraccion.ObtenerInfraccion;

                inputIdPagoInfraccion.Text = pagoinfraccion.Id.ToString();
                inputCodigoInfraccion.Text = infraccion.Codigo;
                inputNombreInfraccion.Text = infraccion.Nombre;

                if (infraccion.esInfraccionGrave())
                {
                    inputGravedadInfraccion.Text = "Infraccion Grave";
                }
                else
                {
                    inputGravedadInfraccion.Text = "Infraccion Leve";
                }

                DateTime fechaVencimiento = pagoinfraccion.getFechaVencimiento();

                decimal pago = infraccion.Importe;
                decimal pagoConDescuento = pagoinfraccion.getImportePendienteInfraccion();
                inputImportePendiente.Text = "$ " + pago.ToString();

                if (pagoConDescuento != pago)
                {
                    inputImportePendienteDescuento.Visible = true;
                    inputImportePendienteDescuento.Text = "$ " + pagoConDescuento.ToString();

                    int descuento = (int)(100 - pagoConDescuento * 100 / pago);
                    inputDescuento.Visible = true;
                    inputDescuento.Text = "% " + descuento.ToString();
                }
                else
                {
                    inputImportePendienteDescuento.Visible = false;
                    inputDescuento.Visible = false;
                }
            }
            else
            {
                inputIdPagoInfraccion.Text = "";
                inputCodigoInfraccion.Text = "";
                inputNombreInfraccion.Text = "";
                inputGravedadInfraccion.Text = "";
                inputImportePendiente.Text = "";
                inputImportePendienteDescuento.Visible = false;
                inputDescuento.Visible = false;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(inputImportePendiente.Text != "")
            {
                PagoInfraccion pagoinfraccion = (PagoInfraccion)listBoxPagosPendientes.SelectedItem;
                decimal importePagado;

                importePagado = pagoinfraccion.getImportePendienteInfraccion();

                adm.registrarElPagoDeInfraccion(pagoinfraccion, importePagado);

                MessageBox.Show("Pago Infracción ralizado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No seleccionó una Infracción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
