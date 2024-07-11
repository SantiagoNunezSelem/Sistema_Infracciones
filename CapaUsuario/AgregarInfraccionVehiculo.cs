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
        private Vehiculo vehiculoSeleccionado;
        private Infraccion infraccionSeleccionada;
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
            List<Infraccion> infracciones = adm.getInfracciones();
            for(int i = 0; i < infracciones.Count; i++)
            {
                materialComboBox1.Items.Add(infracciones[i].Codigo);
            }
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
                    inputModeloVehiculo.Text = buscarVehiculo.Modelo;
                    inputDNIPropietario.Text = buscarVehiculo.DniPropietario;
                }
                else
                {
                    infoBusquedaDominioVehiculo.Text = "No existe";
                    inputModeloVehiculo.Text = "";
                    inputDNIPropietario.Text = "";
                }
                this.vehiculoSeleccionado = buscarVehiculo;
            }
            else
            {
                this.vehiculoSeleccionado = null;
                infoBusquedaDominioVehiculo.Text = "";
            }
            
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = materialComboBox1.Text;
            Infraccion buscarInfraccion = adm.getInfraccion(codigo);

            if (buscarInfraccion != null)
            {
                inputNombreInfraccion.Text = buscarInfraccion.Nombre;
                labelDescInfraccion.Text = buscarInfraccion.Descripcion;
                inputInporte.Text = buscarInfraccion.Importe.ToString();
                if (buscarInfraccion.esInfraccionLeve())
                    inputGravedadInfraccion.Text = "Infraccion Leve";
                else
                    inputGravedadInfraccion.Text = "Infraccion Grave";
            }

            this.infraccionSeleccionada = buscarInfraccion; 
        }

        public bool datosValidos()
        {
            if(vehiculoSeleccionado != null)
            {

                if(infraccionSeleccionada != null)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No seleccionó una infracción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No seleccionó un vehículo","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (datosValidos())
            {
                PagoInfraccion pagoInf = new PagoInfraccion(infraccionSeleccionada, vehiculoSeleccionado, DateTime.Now, 0);
                adm.nuevoPagoInfraccion(pagoInf);
                MessageBox.Show("Infracción registrada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
