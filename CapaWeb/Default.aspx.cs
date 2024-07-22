using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using Microsoft.AspNet.FriendlyUrls;

namespace CapaWeb {
    public partial class _Default: Page {
        protected void Page_Load(object sender, EventArgs e) {
            Administradora adm = (Session["adm"] as Administradora);

            if (adm == null) {
                adm = new Administradora();
                string err = null;
                
                // Check if the connection is success.
                // adm.setConnectionDBPathWeb(AppDomain.CurrentDomain.BaseDirectory);
                adm.setConnectionDBPath(AppDomain.CurrentDomain.BaseDirectory);

                Session["adm"] = adm;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e) {
            Administradora adm = Session["adm"] as Administradora;
            string ownerDni = txtDNI.Text;
            List<Vehiculo> vehicles = adm.getVehiclesByOwner(ownerDni);

            if (vehicles.Count == 0) {
                informationLabel.Text = "La persona con el DNI " + ownerDni + " no posee vehículos registrados.";
            } else {
                Session["ownerDni"] = ownerDni;
                Response.Redirect("ListaDeVechiculos.aspx");
            }
        }
    }
}