namespace Sistema_Infracciones
{
    partial class EliminarInfraccionVehiculo
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
            this.inputIdPagoInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputGravedadInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputImportePendiente = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.inputCodigoInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputPagoConcretado = new MaterialSkin.Controls.MaterialTextBox();
            this.inputNombreInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.listBoxPagos = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.inputModeloVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDNIPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // inputIdPagoInfraccion
            // 
            this.inputIdPagoInfraccion.AnimateReadOnly = false;
            this.inputIdPagoInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputIdPagoInfraccion.Depth = 0;
            this.inputIdPagoInfraccion.Enabled = false;
            this.inputIdPagoInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputIdPagoInfraccion.Hint = "ID Pago Infraccion";
            this.inputIdPagoInfraccion.LeadingIcon = null;
            this.inputIdPagoInfraccion.Location = new System.Drawing.Point(654, 128);
            this.inputIdPagoInfraccion.MaxLength = 50;
            this.inputIdPagoInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputIdPagoInfraccion.Multiline = false;
            this.inputIdPagoInfraccion.Name = "inputIdPagoInfraccion";
            this.inputIdPagoInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputIdPagoInfraccion.TabIndex = 49;
            this.inputIdPagoInfraccion.Text = "";
            this.inputIdPagoInfraccion.TrailingIcon = null;
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
            this.inputGravedadInfraccion.Location = new System.Drawing.Point(654, 309);
            this.inputGravedadInfraccion.MaxLength = 50;
            this.inputGravedadInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputGravedadInfraccion.Multiline = false;
            this.inputGravedadInfraccion.Name = "inputGravedadInfraccion";
            this.inputGravedadInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputGravedadInfraccion.TabIndex = 47;
            this.inputGravedadInfraccion.Text = "";
            this.inputGravedadInfraccion.TrailingIcon = null;
            // 
            // inputImportePendiente
            // 
            this.inputImportePendiente.AnimateReadOnly = false;
            this.inputImportePendiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputImportePendiente.Depth = 0;
            this.inputImportePendiente.Enabled = false;
            this.inputImportePendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputImportePendiente.Hint = "Importe Infraccion";
            this.inputImportePendiente.LeadingIcon = null;
            this.inputImportePendiente.Location = new System.Drawing.Point(27, 345);
            this.inputImportePendiente.MaxLength = 50;
            this.inputImportePendiente.MouseState = MaterialSkin.MouseState.OUT;
            this.inputImportePendiente.Multiline = false;
            this.inputImportePendiente.Name = "inputImportePendiente";
            this.inputImportePendiente.Size = new System.Drawing.Size(223, 50);
            this.inputImportePendiente.TabIndex = 46;
            this.inputImportePendiente.Text = "";
            this.inputImportePendiente.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(27, 421);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(178, 36);
            this.materialButton1.TabIndex = 45;
            this.materialButton1.Text = "Eliminar Infracción";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            this.inputCodigoInfraccion.Location = new System.Drawing.Point(654, 188);
            this.inputCodigoInfraccion.MaxLength = 50;
            this.inputCodigoInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputCodigoInfraccion.Multiline = false;
            this.inputCodigoInfraccion.Name = "inputCodigoInfraccion";
            this.inputCodigoInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputCodigoInfraccion.TabIndex = 44;
            this.inputCodigoInfraccion.Text = "";
            this.inputCodigoInfraccion.TrailingIcon = null;
            // 
            // inputPagoConcretado
            // 
            this.inputPagoConcretado.AnimateReadOnly = false;
            this.inputPagoConcretado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPagoConcretado.Depth = 0;
            this.inputPagoConcretado.Enabled = false;
            this.inputPagoConcretado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputPagoConcretado.Hint = "Estado del Pago";
            this.inputPagoConcretado.LeadingIcon = null;
            this.inputPagoConcretado.Location = new System.Drawing.Point(273, 345);
            this.inputPagoConcretado.MaxLength = 50;
            this.inputPagoConcretado.MouseState = MaterialSkin.MouseState.OUT;
            this.inputPagoConcretado.Multiline = false;
            this.inputPagoConcretado.Name = "inputPagoConcretado";
            this.inputPagoConcretado.Size = new System.Drawing.Size(221, 50);
            this.inputPagoConcretado.TabIndex = 43;
            this.inputPagoConcretado.Text = "";
            this.inputPagoConcretado.TrailingIcon = null;
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
            this.inputNombreInfraccion.Location = new System.Drawing.Point(654, 249);
            this.inputNombreInfraccion.MaxLength = 50;
            this.inputNombreInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNombreInfraccion.Multiline = false;
            this.inputNombreInfraccion.Name = "inputNombreInfraccion";
            this.inputNombreInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputNombreInfraccion.TabIndex = 42;
            this.inputNombreInfraccion.Text = "";
            this.inputNombreInfraccion.TrailingIcon = null;
            // 
            // listBoxPagos
            // 
            this.listBoxPagos.FormattingEnabled = true;
            this.listBoxPagos.Location = new System.Drawing.Point(304, 128);
            this.listBoxPagos.Name = "listBoxPagos";
            this.listBoxPagos.Size = new System.Drawing.Size(309, 173);
            this.listBoxPagos.TabIndex = 41;
            this.listBoxPagos.SelectedIndexChanged += new System.EventHandler(this.listBoxPagos_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(306, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "Infracciones Vehículo";
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
            this.inputModeloVehiculo.Location = new System.Drawing.Point(29, 164);
            this.inputModeloVehiculo.MaxLength = 50;
            this.inputModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputModeloVehiculo.Multiline = false;
            this.inputModeloVehiculo.Name = "inputModeloVehiculo";
            this.inputModeloVehiculo.Size = new System.Drawing.Size(223, 50);
            this.inputModeloVehiculo.TabIndex = 39;
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
            this.inputDNIPropietario.Location = new System.Drawing.Point(29, 239);
            this.inputDNIPropietario.MaxLength = 50;
            this.inputDNIPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDNIPropietario.Multiline = false;
            this.inputDNIPropietario.Name = "inputDNIPropietario";
            this.inputDNIPropietario.Size = new System.Drawing.Size(223, 50);
            this.inputDNIPropietario.TabIndex = 38;
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
            this.inputDominioVehiculo.Location = new System.Drawing.Point(29, 94);
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
            this.inputDominioVehiculo.TabIndex = 37;
            this.inputDominioVehiculo.TabStop = false;
            this.inputDominioVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputDominioVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.inputDominioVehiculo.TrailingIcon = null;
            this.inputDominioVehiculo.UseAccent = false;
            this.inputDominioVehiculo.UseSystemPasswordChar = false;
            this.inputDominioVehiculo.ValidatingType = null;
            this.inputDominioVehiculo.TextChanged += new System.EventHandler(this.inputDominioVehiculo_TextChanged);
            // 
            // EliminarInfraccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 496);
            this.Controls.Add(this.inputIdPagoInfraccion);
            this.Controls.Add(this.inputGravedadInfraccion);
            this.Controls.Add(this.inputImportePendiente);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.inputCodigoInfraccion);
            this.Controls.Add(this.inputPagoConcretado);
            this.Controls.Add(this.inputNombreInfraccion);
            this.Controls.Add(this.listBoxPagos);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.inputModeloVehiculo);
            this.Controls.Add(this.inputDNIPropietario);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Name = "EliminarInfraccionVehiculo";
            this.Text = "Eliminar Infraccion Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox inputIdPagoInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputGravedadInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputImportePendiente;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox inputCodigoInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputPagoConcretado;
        private MaterialSkin.Controls.MaterialTextBox inputNombreInfraccion;
        private System.Windows.Forms.ListBox listBoxPagos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox inputModeloVehiculo;
        private MaterialSkin.Controls.MaterialTextBox inputDNIPropietario;
        private MaterialSkin.Controls.MaterialMaskedTextBox inputDominioVehiculo;
    }
}