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
    public partial class AgregarVehiculo : MaterialForm
    {
        private Administradora adm = Administradora.getInstanciaAdministradora();
        public AgregarVehiculo()
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

            Vehiculo buscarVehiculo;

            buscarVehiculo = adm.getVehiculo(dominio);

            if (buscarVehiculo != null)
            {
                inputDNIPropietario.Enabled = false;
                inputDNIPropietario.Text = buscarVehiculo.DniPropietario;
                inputModeloVehiculo.Enabled = false;
                inputModeloVehiculo.Text = buscarVehiculo.Modelo;
            }
            else
            {
                inputDNIPropietario.Enabled = true;
                inputDNIPropietario.Text = "";
                inputModeloVehiculo.Enabled = true;
                inputModeloVehiculo.Text = "";
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string dominio = inputDominioVehiculo.Text;
            string dniPropietario = inputDNIPropietario.Text;
            string modelo = inputModeloVehiculo.Text;

            if (inputDominioVehiculo.Text != "")
            {
                Vehiculo buscarVehiculo;

                buscarVehiculo = adm.getVehiculo(dominio);
                if (buscarVehiculo == null)
                {
                    if (inputModeloVehiculo.Text != "")
                    {
                        if (inputDNIPropietario.Text != "")
                        {
                            Vehiculo nuevoVehiculo = new Vehiculo(dominio, dniPropietario, modelo);
                            adm.agregarVehiculo(nuevoVehiculo);
                            MessageBox.Show("Vehículo registrado con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se ingresó el DNI del propietario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ingresó el modelo del vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El vehículo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ingresó un dominio de vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
