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
    public partial class ModificarTipoInfraccion : MaterialForm
    {
        private Administradora adm = Administradora.getInstanciaAdministradora();
        private Vehiculo vehiculoSeleccionado;
        private Infraccion infraccionSeleccionada;
        public ModificarTipoInfraccion()
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

        }


    }
