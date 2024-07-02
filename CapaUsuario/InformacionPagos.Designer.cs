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
            this.labelDniPropietario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelModeloVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.infoBusquedaDominioVehiculo = new MaterialSkin.Controls.MaterialLabel();
            this.listBoxPagosPendientes = new System.Windows.Forms.ListBox();
            this.listBoxPagosConcretados = new System.Windows.Forms.ListBox();
            this.listBoxPagosVencidos = new System.Windows.Forms.ListBox();
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
            // labelDniPropietario
            // 
            this.labelDniPropietario.AllowPromptAsInput = true;
            this.labelDniPropietario.AnimateReadOnly = false;
            this.labelDniPropietario.AsciiOnly = false;
            this.labelDniPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelDniPropietario.BeepOnError = false;
            this.labelDniPropietario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelDniPropietario.Depth = 0;
            this.labelDniPropietario.Enabled = false;
            this.labelDniPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDniPropietario.HidePromptOnLeave = false;
            this.labelDniPropietario.HideSelection = true;
            this.labelDniPropietario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.labelDniPropietario.LeadingIcon = null;
            this.labelDniPropietario.Location = new System.Drawing.Point(62, 267);
            this.labelDniPropietario.Mask = "";
            this.labelDniPropietario.MaxLength = 32767;
            this.labelDniPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.labelDniPropietario.Name = "labelDniPropietario";
            this.labelDniPropietario.PasswordChar = '\0';
            this.labelDniPropietario.PrefixSuffixText = null;
            this.labelDniPropietario.PromptChar = '_';
            this.labelDniPropietario.ReadOnly = false;
            this.labelDniPropietario.RejectInputOnFirstFailure = false;
            this.labelDniPropietario.ResetOnPrompt = true;
            this.labelDniPropietario.ResetOnSpace = true;
            this.labelDniPropietario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDniPropietario.SelectedText = "";
            this.labelDniPropietario.SelectionLength = 0;
            this.labelDniPropietario.SelectionStart = 0;
            this.labelDniPropietario.ShortcutsEnabled = true;
            this.labelDniPropietario.Size = new System.Drawing.Size(223, 48);
            this.labelDniPropietario.SkipLiterals = true;
            this.labelDniPropietario.TabIndex = 11;
            this.labelDniPropietario.TabStop = false;
            this.labelDniPropietario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelDniPropietario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelDniPropietario.TrailingIcon = null;
            this.labelDniPropietario.UseAccent = false;
            this.labelDniPropietario.UseSystemPasswordChar = false;
            this.labelDniPropietario.ValidatingType = null;
            // 
            // labelModeloVehiculo
            // 
            this.labelModeloVehiculo.AllowPromptAsInput = true;
            this.labelModeloVehiculo.AnimateReadOnly = false;
            this.labelModeloVehiculo.AsciiOnly = false;
            this.labelModeloVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelModeloVehiculo.BeepOnError = false;
            this.labelModeloVehiculo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelModeloVehiculo.Depth = 0;
            this.labelModeloVehiculo.Enabled = false;
            this.labelModeloVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelModeloVehiculo.HidePromptOnLeave = false;
            this.labelModeloVehiculo.HideSelection = true;
            this.labelModeloVehiculo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.labelModeloVehiculo.LeadingIcon = null;
            this.labelModeloVehiculo.Location = new System.Drawing.Point(62, 196);
            this.labelModeloVehiculo.Mask = "";
            this.labelModeloVehiculo.MaxLength = 32767;
            this.labelModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.labelModeloVehiculo.Name = "labelModeloVehiculo";
            this.labelModeloVehiculo.PasswordChar = '\0';
            this.labelModeloVehiculo.PrefixSuffixText = null;
            this.labelModeloVehiculo.PromptChar = '_';
            this.labelModeloVehiculo.ReadOnly = false;
            this.labelModeloVehiculo.RejectInputOnFirstFailure = false;
            this.labelModeloVehiculo.ResetOnPrompt = true;
            this.labelModeloVehiculo.ResetOnSpace = true;
            this.labelModeloVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelModeloVehiculo.SelectedText = "";
            this.labelModeloVehiculo.SelectionLength = 0;
            this.labelModeloVehiculo.SelectionStart = 0;
            this.labelModeloVehiculo.ShortcutsEnabled = true;
            this.labelModeloVehiculo.Size = new System.Drawing.Size(223, 48);
            this.labelModeloVehiculo.SkipLiterals = true;
            this.labelModeloVehiculo.TabIndex = 10;
            this.labelModeloVehiculo.TabStop = false;
            this.labelModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelModeloVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelModeloVehiculo.TrailingIcon = null;
            this.labelModeloVehiculo.UseAccent = false;
            this.labelModeloVehiculo.UseSystemPasswordChar = false;
            this.labelModeloVehiculo.ValidatingType = null;
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
            // InformacionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 497);
            this.Controls.Add(this.listBoxPagosVencidos);
            this.Controls.Add(this.listBoxPagosConcretados);
            this.Controls.Add(this.listBoxPagosPendientes);
            this.Controls.Add(this.infoBusquedaDominioVehiculo);
            this.Controls.Add(this.labelDniPropietario);
            this.Controls.Add(this.labelModeloVehiculo);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "InformacionPagos";
            this.Text = "InformacionPagos";
            this.Load += new System.EventHandler(this.InformacionPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelDniPropietario;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelModeloVehiculo;
        private MaterialSkin.Controls.MaterialMaskedTextBox inputDominioVehiculo;
        private MaterialSkin.Controls.MaterialLabel infoBusquedaDominioVehiculo;
        private System.Windows.Forms.ListBox listBoxPagosPendientes;
        private System.Windows.Forms.ListBox listBoxPagosConcretados;
        private System.Windows.Forms.ListBox listBoxPagosVencidos;
    }
}