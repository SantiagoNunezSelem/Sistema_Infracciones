namespace Sistema_Infracciones
{
    partial class PagoInfraccionVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputModeloVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDNIPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.listBoxPagosPendientes = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.inputNombreInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputImporteAPagar = new MaterialSkin.Controls.MaterialTextBox();
            this.inputCodigoInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.inputImporteFinalPendiente = new MaterialSkin.Controls.MaterialTextBox();
            this.inputGravedadInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // inputModeloVehiculo
            // 
            this.inputModeloVehiculo.AnimateReadOnly = false;
            this.inputModeloVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputModeloVehiculo.Depth = 0;
            this.inputModeloVehiculo.Enabled = false;
            this.inputModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputModeloVehiculo.Hint = "Modelo";
            this.inputModeloVehiculo.LeadingIcon = null;
            this.inputModeloVehiculo.Location = new System.Drawing.Point(50, 173);
            this.inputModeloVehiculo.MaxLength = 50;
            this.inputModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputModeloVehiculo.Multiline = false;
            this.inputModeloVehiculo.Name = "inputModeloVehiculo";
            this.inputModeloVehiculo.Size = new System.Drawing.Size(223, 50);
            this.inputModeloVehiculo.TabIndex = 26;
            this.inputModeloVehiculo.Text = "";
            this.inputModeloVehiculo.TrailingIcon = null;
            // 
            // inputDNIPropietario
            // 
            this.inputDNIPropietario.AnimateReadOnly = false;
            this.inputDNIPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDNIPropietario.Depth = 0;
            this.inputDNIPropietario.Enabled = false;
            this.inputDNIPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDNIPropietario.Hint = "DNI Propietario";
            this.inputDNIPropietario.LeadingIcon = null;
            this.inputDNIPropietario.Location = new System.Drawing.Point(50, 248);
            this.inputDNIPropietario.MaxLength = 50;
            this.inputDNIPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDNIPropietario.Multiline = false;
            this.inputDNIPropietario.Name = "inputDNIPropietario";
            this.inputDNIPropietario.Size = new System.Drawing.Size(223, 50);
            this.inputDNIPropietario.TabIndex = 25;
            this.inputDNIPropietario.Text = "";
            this.inputDNIPropietario.TrailingIcon = null;
            // 
            // inputDominioVehiculo
            // 
            this.inputDominioVehiculo.AllowPromptAsInput = true;
            this.inputDominioVehiculo.AnimateReadOnly = false;
            this.inputDominioVehiculo.AsciiOnly = false;
            this.inputDominioVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inputDominioVehiculo.BeepOnError = false;
            this.inputDominioVehiculo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.inputDominioVehiculo.Depth = 0;
            this.inputDominioVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDominioVehiculo.HidePromptOnLeave = false;
            this.inputDominioVehiculo.HideSelection = true;
            this.inputDominioVehiculo.Hint = "Dominio del Vehículo";
            this.inputDominioVehiculo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.inputDominioVehiculo.LeadingIcon = null;
            this.inputDominioVehiculo.Location = new System.Drawing.Point(50, 103);
            this.inputDominioVehiculo.Mask = "";
            this.inputDominioVehiculo.MaxLength = 32767;
            this.inputDominioVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDominioVehiculo.Name = "inputDominioVehiculo";
            this.inputDominioVehiculo.PasswordChar = '\0';
            this.inputDominioVehiculo.PrefixSuffixText = null;
            this.inputDominioVehiculo.PromptChar = '_';
            this.inputDominioVehiculo.ReadOnly = false;
            this.inputDominioVehiculo.RejectInputOnFirstFailure = false;
            this.inputDominioVehiculo.ResetOnPrompt = true;
            this.inputDominioVehiculo.ResetOnSpace = true;
            this.inputDominioVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputDominioVehiculo.SelectedText = "";
            this.inputDominioVehiculo.SelectionLength = 0;
            this.inputDominioVehiculo.SelectionStart = 0;
            this.inputDominioVehiculo.ShortcutsEnabled = true;
            this.inputDominioVehiculo.Size = new System.Drawing.Size(223, 48);
            this.inputDominioVehiculo.SkipLiterals = true;
            this.inputDominioVehiculo.TabIndex = 24;
            this.inputDominioVehiculo.TabStop = false;
            this.inputDominioVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputDominioVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.inputDominioVehiculo.TrailingIcon = null;
            this.inputDominioVehiculo.UseAccent = false;
            this.inputDominioVehiculo.UseSystemPasswordChar = false;
            this.inputDominioVehiculo.ValidatingType = null;
            this.inputDominioVehiculo.TextChanged += new System.EventHandler(this.inputDominioVehiculo_TextChanged);
            // 
            // listBoxPagosPendientes
            // 
            this.listBoxPagosPendientes.FormattingEnabled = true;
            this.listBoxPagosPendientes.Location = new System.Drawing.Point(325, 137);
            this.listBoxPagosPendientes.Name = "listBoxPagosPendientes";
            this.listBoxPagosPendientes.Size = new System.Drawing.Size(309, 173);
            this.listBoxPagosPendientes.TabIndex = 28;
            this.listBoxPagosPendientes.SelectedIndexChanged += new System.EventHandler(this.listBoxPagosPendientes_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(327, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 19);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "Infracción Pagos Pendientes";
            // 
            // inputNombreInfraccion
            // 
            this.inputNombreInfraccion.AnimateReadOnly = false;
            this.inputNombreInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNombreInfraccion.Depth = 0;
            this.inputNombreInfraccion.Enabled = false;
            this.inputNombreInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputNombreInfraccion.Hint = "Nombre Infracción";
            this.inputNombreInfraccion.LeadingIcon = null;
            this.inputNombreInfraccion.Location = new System.Drawing.Point(666, 198);
            this.inputNombreInfraccion.MaxLength = 50;
            this.inputNombreInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNombreInfraccion.Multiline = false;
            this.inputNombreInfraccion.Name = "inputNombreInfraccion";
            this.inputNombreInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputNombreInfraccion.TabIndex = 29;
            this.inputNombreInfraccion.Text = "";
            this.inputNombreInfraccion.TrailingIcon = null;
            // 
            // inputImporteAPagar
            // 
            this.inputImporteAPagar.AnimateReadOnly = false;
            this.inputImporteAPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputImporteAPagar.Depth = 0;
            this.inputImporteAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputImporteAPagar.Hint = "Importe a Pagar";
            this.inputImporteAPagar.LeadingIcon = null;
            this.inputImporteAPagar.Location = new System.Drawing.Point(298, 354);
            this.inputImporteAPagar.MaxLength = 50;
            this.inputImporteAPagar.MouseState = MaterialSkin.MouseState.OUT;
            this.inputImporteAPagar.Multiline = false;
            this.inputImporteAPagar.Name = "inputImporteAPagar";
            this.inputImporteAPagar.Size = new System.Drawing.Size(223, 50);
            this.inputImporteAPagar.TabIndex = 30;
            this.inputImporteAPagar.Text = "";
            this.inputImporteAPagar.TrailingIcon = null;
            // 
            // inputCodigoInfraccion
            // 
            this.inputCodigoInfraccion.AnimateReadOnly = false;
            this.inputCodigoInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCodigoInfraccion.Depth = 0;
            this.inputCodigoInfraccion.Enabled = false;
            this.inputCodigoInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputCodigoInfraccion.Hint = "Codigo Infracción";
            this.inputCodigoInfraccion.LeadingIcon = null;
            this.inputCodigoInfraccion.Location = new System.Drawing.Point(666, 137);
            this.inputCodigoInfraccion.MaxLength = 50;
            this.inputCodigoInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputCodigoInfraccion.Multiline = false;
            this.inputCodigoInfraccion.Name = "inputCodigoInfraccion";
            this.inputCodigoInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputCodigoInfraccion.TabIndex = 31;
            this.inputCodigoInfraccion.Text = "";
            this.inputCodigoInfraccion.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(48, 428);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(142, 36);
            this.materialButton1.TabIndex = 32;
            this.materialButton1.Text = "Registrar Pago";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // inputImporteFinalPendiente
            // 
            this.inputImporteFinalPendiente.AnimateReadOnly = false;
            this.inputImporteFinalPendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputImporteFinalPendiente.Depth = 0;
            this.inputImporteFinalPendiente.Enabled = false;
            this.inputImporteFinalPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputImporteFinalPendiente.Hint = "Importe Final Pendiente";
            this.inputImporteFinalPendiente.LeadingIcon = null;
            this.inputImporteFinalPendiente.Location = new System.Drawing.Point(48, 354);
            this.inputImporteFinalPendiente.MaxLength = 50;
            this.inputImporteFinalPendiente.MouseState = MaterialSkin.MouseState.OUT;
            this.inputImporteFinalPendiente.Multiline = false;
            this.inputImporteFinalPendiente.Name = "inputImporteFinalPendiente";
            this.inputImporteFinalPendiente.Size = new System.Drawing.Size(223, 50);
            this.inputImporteFinalPendiente.TabIndex = 33;
            this.inputImporteFinalPendiente.Text = "";
            this.inputImporteFinalPendiente.TrailingIcon = null;
            // 
            // inputGravedadInfraccion
            // 
            this.inputGravedadInfraccion.AnimateReadOnly = false;
            this.inputGravedadInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputGravedadInfraccion.Depth = 0;
            this.inputGravedadInfraccion.Enabled = false;
            this.inputGravedadInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputGravedadInfraccion.Hint = "Gravedad Infracción";
            this.inputGravedadInfraccion.LeadingIcon = null;
            this.inputGravedadInfraccion.Location = new System.Drawing.Point(666, 258);
            this.inputGravedadInfraccion.MaxLength = 50;
            this.inputGravedadInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputGravedadInfraccion.Multiline = false;
            this.inputGravedadInfraccion.Name = "inputGravedadInfraccion";
            this.inputGravedadInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputGravedadInfraccion.TabIndex = 34;
            this.inputGravedadInfraccion.Text = "";
            this.inputGravedadInfraccion.TrailingIcon = null;
            // 
            // PagoInfraccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 505);
            this.Controls.Add(this.inputGravedadInfraccion);
            this.Controls.Add(this.inputImporteFinalPendiente);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.inputCodigoInfraccion);
            this.Controls.Add(this.inputImporteAPagar);
            this.Controls.Add(this.inputNombreInfraccion);
            this.Controls.Add(this.listBoxPagosPendientes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.inputModeloVehiculo);
            this.Controls.Add(this.inputDNIPropietario);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Name = "PagoInfraccionVehiculo";
            this.Text = "PagoInfraccionVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox inputModeloVehiculo;
        private MaterialSkin.Controls.MaterialTextBox inputDNIPropietario;
        private MaterialSkin.Controls.MaterialMaskedTextBox inputDominioVehiculo;
        private System.Windows.Forms.ListBox listBoxPagosPendientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox inputNombreInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputImporteAPagar;
        private MaterialSkin.Controls.MaterialTextBox inputCodigoInfraccion;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox inputImporteFinalPendiente;
        private MaterialSkin.Controls.MaterialTextBox inputGravedadInfraccion;
    }
}