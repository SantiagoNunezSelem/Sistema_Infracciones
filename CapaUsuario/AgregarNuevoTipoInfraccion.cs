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
    public partial class AgregarNuevoTipoInfraccion : MaterialForm
    {
        Administradora adm = Administradora.getInstanciaAdministradora();

        Infraccion buscarInfraccion;

        string recuperarNombre;
        string recuperarDesc;
        string recuperarGravedad;
        string recuperarImporte;

        public AgregarNuevoTipoInfraccion()
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

            if (inputImporteInfraccion.Enabled == true)
            {
                //Guardar los datos que ingresó el usuario antes de sobreescribirlos
                recuperarNombre = inputNombreInfraccion.Text;
                recuperarGravedad = inputGravedadInfraccion.Text;
                recuperarDesc = inputDescInfraccion.Text;
                recuperarImporte = inputImporteInfraccion.Text;
            }

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

                inputNombreInfraccion.Enabled = false;
                inputGravedadInfraccion.Enabled = false;
                inputDescInfraccion.Enabled = false;
                inputImporteInfraccion.Enabled = false;
            }
            else
            {
                inputNombreInfraccion.Text = recuperarNombre;
                inputGravedadInfraccion.Text = recuperarGravedad;
                inputDescInfraccion.Text = recuperarDesc;
                inputImporteInfraccion.Text = recuperarImporte;

                inputNombreInfraccion.Enabled = true;
                inputGravedadInfraccion.Enabled = true;
                inputDescInfraccion.Enabled = true;
                inputImporteInfraccion.Enabled = true;
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = inputCodigoInfraccion.Text;
            string nombre = inputNombreInfraccion.Text;
            string desc = inputDescInfraccion.Text;
            string importe = inputImporteInfraccion.Text;
            string gravedad = inputGravedadInfraccion.Text;

            if (codigo != "")
            {
                if(buscarInfraccion == null)
                {
                    decimal importeDecimal = getImporte(importe);
                    if (importeDecimal != -1)
                    {
                        if (gravedad == "Infraccion Leve")
                        {
                            InfraccionLeve nuevaInfraccion = new InfraccionLeve(codigo, nombre, desc, importeDecimal);
                            adm.agregarTipoInfraccion(nuevaInfraccion);
                        }
                        if (gravedad == "Infraccion Grave")
                        {
                            InfraccionGrave nuevaInfraccion = new InfraccionGrave(codigo, nombre, desc, importeDecimal);
                            adm.agregarTipoInfraccion(nuevaInfraccion);
                        }

                        MessageBox.Show("Se guardó la Infracción con Éxito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Importe Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El codigo de la Infracción ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresó ningun codigo de Infracción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal getImporte(string importe)
        {
            try
            {
                return decimal.Parse(importe);
            }
            catch
            {
                return -1;
            }
        }
    }
}
