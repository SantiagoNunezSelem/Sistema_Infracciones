using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace CapaWeb {
    public partial class _ListaDeVehiculos: Page {
        protected void Page_Load(object sender, EventArgs e) {
            Administradora adm = (Session["adm"] as Administradora);
            string ownerDni = Session["ownerDni"] as string;

            if (adm == null || ownerDni == null)
                Response.Redirect("Default.aspx");


                List<Vehiculo> vehicles = adm.getVehiclesByOwner(ownerDni);
                var vehiclesData = new string[vehicles.Count];
                
                int index = 0;

                vehicles.ForEach(vehicle => {
                    string text = vehicle.Dominio + " - " + vehicle.Modelo;

                    vehiclesData.SetValue(new { value = vehicle.Dominio, text }, index);
                    index++;

                    return;
                });

                ddlVehiculos.DataSource = vehiclesData;// Defines where the data comes from.
                ddlVehiculos.DataTextField = "text"; // Defines the attribute that is taken to display the text
                ddlVehiculos.DataValueField = "value"; // Defines the attribute that is taken to value

                ddlVehiculos.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e) {
            /*Administradora adm = Session["adm"] as Administradora;*/

            btnSelect.Text = "Vehículo seleccionado: " + ddlVehiculos.SelectedValue + "/" + ddlVehiculos.SelectedItem;

            Session["dominio"] = ddlVehiculos.SelectedValue;
        }
    }
}