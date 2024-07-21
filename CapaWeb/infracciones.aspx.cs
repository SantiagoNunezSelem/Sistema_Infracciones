using CapaNegocio;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iText.Layout;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace CapaWeb {
    public partial class infracciones: Page {
        private static readonly string[] infraccionesPagas =
        {
            "Infracción 1 - $100 - Pagada",
            "Infracción 2 - $200 - Pagada"
        };

        private static readonly string[] infraccionesImpagas =
        {
            "Infracción 3 - $300 - Impaga",
            "Infracción 4 - $400 - Impaga"
        };

        protected void Page_Load(object sender, EventArgs e) {
            Administradora adm = (Session["adm"] as Administradora);
            string dominio = Session["dominio"] as string;

            if (!IsPostBack) {
                if (adm == null)
                    Response.Redirect("Default.aspx");
            }

            labelTitle.Text = dominio;
            Vehiculo v = adm.getVehiculo(dominio);
            List<PagoInfraccion> pagas = v.getPagosInfraccionesConcretadas();
            List<PagoInfraccion> impagas = v.getPagosInfraccionesPendientes();

            string[] infraccionesPagas = new string[pagas.Count];
            string[] infraccionesImpagas = new string[impagas.Count];

            for (int i = 0; i < pagas.Count; i++)
                infraccionesPagas[i] = pagas[i].DisplayTextPagoConcretado;

            for (int i = 0; i < impagas.Count; i++)
                infraccionesImpagas[i] = impagas[i].DisplayTextPagoPendiente;

            rptInfraccionesPagas.DataSource = infraccionesPagas;
            rptInfraccionesPagas.DataBind();

            rptInfraccionesImpagas.DataSource = infraccionesImpagas;
            rptInfraccionesImpagas.DataBind();
        }

        protected void btnGeneratePDF_Click(object sender, EventArgs e) {
            var button = (Button) sender;
            var infraccion = button.CommandArgument;

            GeneratePDF(infraccion);
        }

        private void GeneratePDF(string infraccion) {
            using (MemoryStream ms = new MemoryStream()) {
                PdfWriter writer = new PdfWriter(ms);
                PdfDocument pdfDoc = new PdfDocument(writer);
                Document document = new Document(pdfDoc);

                document.Add(new Paragraph("Orden de Pago de Infracciones Impagas"));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("Detalles de la infracción:"));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph(infraccion));

                document.Close();

                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=OrdenPagoInfraccion.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite(ms.ToArray());
                Response.End();
            }
        }
    }
}