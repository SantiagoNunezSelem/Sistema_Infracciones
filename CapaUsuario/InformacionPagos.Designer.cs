namespace Sistema_Infracciones
{
    partial class InformacionPagos
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.infoBusquedaDominioVehiculo = new MaterialSkin.Controls.MaterialLabel();
            this.listBoxPagosPendientes = new System.Windows.Forms.ListBox();
            this.listBoxPagosConcretados = new System.Windows.Forms.ListBox();
            this.listBoxPagosVencidos = new System.Windows.Forms.ListBox();
            this.inputDNIPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputModeloVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(382, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(203, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Infracción Pagos Pendientes";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(697, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(214, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Infracción Pagos Concretados";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(382, 296);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(190, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Infracción Pagos Vencidos";
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
            this.inputDominioVehiculo.Location = new System.Drawing.Point(62, 126);
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
            this.inputDominioVehiculo.TabIndex = 9;
            this.inputDominioVehiculo.TabStop = false;
            this.inputDominioVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputDominioVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.inputDominioVehiculo.TrailingIcon = null;
            this.inputDominioVehiculo.UseAccent = false;
            this.inputDominioVehiculo.UseSystemPasswordChar = false;
            this.inputDominioVehiculo.ValidatingType = null;
            this.inputDominioVehiculo.TextChanged += new System.EventHandler(this.inputDominioVehiculo_TextChanged);
            // 
            // infoBusquedaDominioVehiculo
            // 
            this.infoBusquedaDominioVehiculo.AutoSize = true;
            this.infoBusquedaDominioVehiculo.Depth = 0;
            this.infoBusquedaDominioVehiculo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoBusquedaDominioVehiculo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoBusquedaDominioVehiculo.Location = new System.Drawing.Point(71, 79);
            this.infoBusquedaDominioVehiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoBusquedaDominioVehiculo.Name = "infoBusquedaDominioVehiculo";
            this.infoBusquedaDominioVehiculo.Size = new System.Drawing.Size(1, 0);
            this.infoBusquedaDominioVehiculo.TabIndex = 16;
            // 
            // listBoxPagosPendientes
            // 
            this.listBoxPagosPendientes.FormattingEnabled = true;
            this.listBoxPagosPendientes.Location = new System.Drawing.Point(380, 138);
            this.listBoxPagosPendientes.Name = "listBoxPagosPendientes";
            this.listBoxPagosPendientes.Size = new System.Drawing.Size(263, 121);
            this.listBoxPagosPendientes.TabIndex = 17;
            // 
            // listBoxPagosConcretados
            // 
            this.listBoxPagosConcretados.FormattingEnabled = true;
            this.listBoxPagosConcretados.Location = new System.Drawing.Point(695, 138);
            this.listBoxPagosConcretados.Name = "listBoxPagosConcretados";
            this.listBoxPagosConcretados.Size = new System.Drawing.Size(263, 121);
            this.listBoxPagosConcretados.TabIndex = 18;
            // 
            // listBoxPagosVencidos
            // 
            this.listBoxPagosVencidos.FormattingEnabled = true;
            this.listBoxPagosVencidos.Location = new System.Drawing.Point(380, 329);
            this.listBoxPagosVencidos.Name = "listBoxPagosVencidos";
            this.listBoxPagosVencidos.Size = new System.Drawing.Size(263, 121);
            this.listBoxPagosVencidos.TabIndex = 19;
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
            this.inputDNIPropietario.Location = new System.Drawing.Point(62, 274);
            this.inputDNIPropietario.MaxLength = 50;
            this.inputDNIPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDNIPropietario.Multiline = false;
            this.inputDNIPropietario.Name = "inputDNIPropietario";
            this.inputDNIPropietario.Size = new System.Drawing.Size(223, 50);
            this.inputDNIPropietario.TabIndex = 20;
            this.inputDNIPropietario.Text = "";
            this.inputDNIPropietario.TrailingIcon = null;
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
            this.inputModeloVehiculo.Location = new System.Drawing.Point(62, 199);
            this.inputModeloVehiculo.MaxLength = 50;
            this.inputModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputModeloVehiculo.Multiline = false;
            this.inputModeloVehiculo.Name = "inputModeloVehiculo";
            this.inputModeloVehiculo.Size = new System.Drawing.Size(223, 50);
            this.inputModeloVehiculo.TabIndex = 21;
            this.inputModeloVehiculo.Text = "";
            this.inputModeloVehiculo.TrailingIcon = null;
            // 
            // InformacionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 497);
            this.Controls.Add(this.inputModeloVehiculo);
            this.Controls.Add(this.inputDNIPropietario);
            this.Controls.Add(this.listBoxPagosVencidos);
            this.Controls.Add(this.listBoxPagosConcretados);
            this.Controls.Add(this.listBoxPagosPendientes);
            this.Controls.Add(this.infoBusquedaDominioVehiculo);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "InformacionPagos";
            this.Text = "InformacionPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox inputDominioVehiculo;
        private MaterialSkin.Controls.MaterialLabel infoBusquedaDominioVehiculo;
        private System.Windows.Forms.ListBox listBoxPagosPendientes;
        private System.Windows.Forms.ListBox listBoxPagosConcretados;
        private System.Windows.Forms.ListBox listBoxPagosVencidos;
        private MaterialSkin.Controls.MaterialTextBox inputDNIPropietario;
        private MaterialSkin.Controls.MaterialTextBox inputModeloVehiculo;
    }
}