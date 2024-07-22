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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Sistema_Infracciones
{
    public partial class EliminarTipoInfraccion : MaterialForm
    {
        Administradora adm = Administradora.getInstanciaAdministradora();

        Infraccion buscarInfraccion;

        public EliminarTipoInfraccion()
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

        private void inputCodigoInfraccion_TextChanged(object sender, EventArgs e)
        {
            string codigoInfraccion = inputCodigoInfraccion.Text;

            this.buscarInfraccion = adm.getInfraccion(codigoInfraccion);

            if (buscarInfraccion != null)
            {
                inputNombreInfraccion.Text = buscarInfraccion.Nombre;
                if (buscarInfraccion.esInfraccionLeve())
                {
                    inputGravedadInfraccion.Text = "Infracción Grave";
                }
                else
                {
                    inputGravedadInfraccion.Text = "Infracción Leve";
                }
                inputDescInfraccion.Text = buscarInfraccion.Descripcion;
                inputImporteInfraccion.Text = buscarInfraccion.Importe.ToString();
            }
            else
            {
                inputNombreInfraccion.Text = "";
                inputGravedadInfraccion.Text = "";
                inputDescInfraccion.Text = "";
                inputImporteInfraccion.Text = "";
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            /*
            Eliminar un tipoInfraccion:
                - Eliminarlo de la lista de tipos de infracciones (en la administradora)
                - Eliminar todos los PagoInfracciones asociadas a ese tipoInfraccion (pagados o no pagados)
                - Eliminarlo de la DB (tabla: TipoInfraccion)
                - Eliminar de la DB todos los PagoInfracciones asociados a ese tipoInfraccion (pagados o no pagados)
                - Advertir al usuario de todos los cambios y mostrar el texto "Continuar?" con 2 botones (Si, No)
             */

            string codigo = inputCodigoInfraccion.Text;

            if (codigo != "")
            {
                if (buscarInfraccion != null)
                {
                    DialogResult option = MessageBox.Show("Al eliminar el tipo de infracción, también se eliminar todos los pagos de infracción asociados al mismo. Desea continuar?", 
                                                          "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(option == DialogResult.Yes)
                    {
                        adm.eliminarTipoInfraccion(buscarInfraccion);
                        MessageBox.Show("Se eliminó el tipo infracción con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("El codigo de la Infracción no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresó ningun codigo de Infracción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
