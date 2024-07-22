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
    public partial class EliminarInfraccionVehiculo : MaterialForm
    {
        private Administradora adm = Administradora.getInstanciaAdministradora();
        private Vehiculo vehiculoSeleccionado;

        public EliminarInfraccionVehiculo()
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
                    listBoxPagos.DataSource = null;
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

            pagosInfracciones = vehiculoSeleccionado.getPagos();

            listBoxPagos.DataSource = pagosInfracciones;
            listBoxPagos.DisplayMember = "DisplayTextPagoPendiente";
        }

        private void listBoxPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

            PagoInfraccion pagoinfraccion = (PagoInfraccion)listBoxPagos.SelectedItem;
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

                if(pagoinfraccion.pagoCompleto())
                {
                    inputPagoConcretado.Text = "Pago Concretado";
                }
                else
                {
                    inputPagoConcretado.Text = "Pago Pendiente";
                }
            }
            else
            {
                inputIdPagoInfraccion.Text = "";
                inputCodigoInfraccion.Text = "";
                inputNombreInfraccion.Text = "";
                inputGravedadInfraccion.Text = "";
                inputImportePendiente.Text = "";
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (inputImportePendiente.Text != "")
            {
                PagoInfraccion pagoinfraccion = (PagoInfraccion)listBoxPagos.SelectedItem;

                DialogResult option = MessageBox.Show("No se puede revertir esta acción. Desea continuar?",
                                                          "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (option == DialogResult.Yes)
                {
                    adm.eliminarPagoInfraccion(pagoinfraccion);
                    MessageBox.Show("Se eliminó la infracción con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No seleccionó una Infracción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
