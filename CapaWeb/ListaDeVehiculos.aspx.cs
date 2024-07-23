using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace CapaWeb {
    public partial class _ListaDeVehiculos: Page {
        public class VehicleData {
            public string Value { get; set; }
            public string Text { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e) {
                Administradora adm = (Session["adm"] as Administradora);
                string ownerDni = Session["ownerDni"] as string;

                if (adm == null || ownerDni == null)
                    Response.Redirect("Default.aspx");

                List<Vehiculo> vehicles = adm.getVehiclesByOwner(ownerDni);
                VehicleData[] vehiclesData = new VehicleData[vehicles.Count];

                int index = 0;

                vehicles.ForEach(vehicle => {
                    string text = vehicle.Dominio + " - " + vehicle.Modelo;
                    vehiclesData[index] = new VehicleData { Value = vehicle.Dominio, Text = text };
                    index++;

                    return;
                });

                ddlVehiculos.DataSource = vehiclesData;// Defines where the data comes from.
                ddlVehiculos.DataTextField = "Text"; // Defines the attribute that is taken to display the text
                ddlVehiculos.DataValueField = "Value"; // Defines the attribute that is taken to value

                ddlVehiculos.DataBind();
        }

        protected void btnSelect_Click(object sender, EventArgs e) {
            /*Administradora adm = Session["adm"] as Administradora;*/

            /*btnSelect.Text = "Vehículo seleccionado: " + ddlVehiculos.SelectedValue + "/" + ddlVehiculos.SelectedItem;*/

            Session["dominio"] = ddlVehiculos.SelectedValue;
            Response.Redirect("infracciones.aspx");
        }
    }
}