namespace Sistema_Infracciones
{
    partial class AgregarInfraccionVehiculo
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelModeloVehiculo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.labelDniPropietario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelImporte = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelDescInfraccion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.labelGravedadInfraccion = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.labelNombre = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.infoBusquedaDominioVehiculo = new MaterialSkin.Controls.MaterialLabel();
            this.administradoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.administradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.administradoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(311, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 1;
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
            this.inputDominioVehiculo.Location = new System.Drawing.Point(41, 100);
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
            this.inputDominioVehiculo.TabIndex = 4;
            this.inputDominioVehiculo.TabStop = false;
            this.inputDominioVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputDominioVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.inputDominioVehiculo.TrailingIcon = null;
            this.inputDominioVehiculo.UseAccent = false;
            this.inputDominioVehiculo.UseSystemPasswordChar = false;
            this.inputDominioVehiculo.ValidatingType = null;
            this.inputDominioVehiculo.TextChanged += new System.EventHandler(this.inputDominioVehiculo_TextChanged);
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
            this.labelModeloVehiculo.Location = new System.Drawing.Point(41, 170);
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
            this.labelModeloVehiculo.TabIndex = 5;
            this.labelModeloVehiculo.TabStop = false;
            this.labelModeloVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelModeloVehiculo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelModeloVehiculo.TrailingIcon = null;
            this.labelModeloVehiculo.UseAccent = false;
            this.labelModeloVehiculo.UseSystemPasswordChar = false;
            this.labelModeloVehiculo.ValidatingType = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Tipo de Infracción";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(330, 100);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(183, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 7;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
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
            this.labelDniPropietario.Location = new System.Drawing.Point(41, 241);
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
            this.labelDniPropietario.TabIndex = 8;
            this.labelDniPropietario.TabStop = false;
            this.labelDniPropietario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelDniPropietario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelDniPropietario.TrailingIcon = null;
            this.labelDniPropietario.UseAccent = false;
            this.labelDniPropietario.UseSystemPasswordChar = false;
            this.labelDniPropietario.ValidatingType = null;
            // 
            // labelImporte
            // 
            this.labelImporte.AllowPromptAsInput = true;
            this.labelImporte.AnimateReadOnly = false;
            this.labelImporte.AsciiOnly = false;
            this.labelImporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelImporte.BeepOnError = false;
            this.labelImporte.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelImporte.Depth = 0;
            this.labelImporte.Enabled = false;
            this.labelImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelImporte.HidePromptOnLeave = false;
            this.labelImporte.HideSelection = true;
            this.labelImporte.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.labelImporte.LeadingIcon = null;
            this.labelImporte.Location = new System.Drawing.Point(330, 316);
            this.labelImporte.Mask = "";
            this.labelImporte.MaxLength = 32767;
            this.labelImporte.MouseState = MaterialSkin.MouseState.OUT;
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.PasswordChar = '\0';
            this.labelImporte.PrefixSuffixText = null;
            this.labelImporte.PromptChar = '_';
            this.labelImporte.ReadOnly = false;
            this.labelImporte.RejectInputOnFirstFailure = false;
            this.labelImporte.ResetOnPrompt = true;
            this.labelImporte.ResetOnSpace = true;
            this.labelImporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelImporte.SelectedText = "";
            this.labelImporte.SelectionLength = 0;
            this.labelImporte.SelectionStart = 0;
            this.labelImporte.ShortcutsEnabled = true;
            this.labelImporte.Size = new System.Drawing.Size(237, 48);
            this.labelImporte.SkipLiterals = true;
            this.labelImporte.TabIndex = 9;
            this.labelImporte.TabStop = false;
            this.labelImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelImporte.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelImporte.TrailingIcon = null;
            this.labelImporte.UseAccent = false;
            this.labelImporte.UseSystemPasswordChar = false;
            this.labelImporte.ValidatingType = null;
            // 
            // labelDescInfraccion
            // 
            this.labelDescInfraccion.AnimateReadOnly = false;
            this.labelDescInfraccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelDescInfraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.labelDescInfraccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDescInfraccion.Depth = 0;
            this.labelDescInfraccion.Enabled = false;
            this.labelDescInfraccion.HideSelection = true;
            this.labelDescInfraccion.Location = new System.Drawing.Point(330, 170);
            this.labelDescInfraccion.MaxLength = 32767;
            this.labelDescInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.labelDescInfraccion.Name = "labelDescInfraccion";
            this.labelDescInfraccion.PasswordChar = '\0';
            this.labelDescInfraccion.ReadOnly = false;
            this.labelDescInfraccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.labelDescInfraccion.SelectedText = "";
            this.labelDescInfraccion.SelectionLength = 0;
            this.labelDescInfraccion.SelectionStart = 0;
            this.labelDescInfraccion.ShortcutsEnabled = true;
            this.labelDescInfraccion.Size = new System.Drawing.Size(498, 119);
            this.labelDescInfraccion.TabIndex = 11;
            this.labelDescInfraccion.TabStop = false;
            this.labelDescInfraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelDescInfraccion.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(330, 390);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Guardar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // labelGravedadInfraccion
            // 
            this.labelGravedadInfraccion.AllowPromptAsInput = true;
            this.labelGravedadInfraccion.AnimateReadOnly = false;
            this.labelGravedadInfraccion.AsciiOnly = false;
            this.labelGravedadInfraccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelGravedadInfraccion.BeepOnError = false;
            this.labelGravedadInfraccion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelGravedadInfraccion.Depth = 0;
            this.labelGravedadInfraccion.Enabled = false;
            this.labelGravedadInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelGravedadInfraccion.HidePromptOnLeave = false;
            this.labelGravedadInfraccion.HideSelection = true;
            this.labelGravedadInfraccion.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.labelGravedadInfraccion.LeadingIcon = null;
            this.labelGravedadInfraccion.Location = new System.Drawing.Point(585, 316);
            this.labelGravedadInfraccion.Mask = "";
            this.labelGravedadInfraccion.MaxLength = 32767;
            this.labelGravedadInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.labelGravedadInfraccion.Name = "labelGravedadInfraccion";
            this.labelGravedadInfraccion.PasswordChar = '\0';
            this.labelGravedadInfraccion.PrefixSuffixText = null;
            this.labelGravedadInfraccion.PromptChar = '_';
            this.labelGravedadInfraccion.ReadOnly = false;
            this.labelGravedadInfraccion.RejectInputOnFirstFailure = false;
            this.labelGravedadInfraccion.ResetOnPrompt = true;
            this.labelGravedadInfraccion.ResetOnSpace = true;
            this.labelGravedadInfraccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGravedadInfraccion.SelectedText = "";
            this.labelGravedadInfraccion.SelectionLength = 0;
            this.labelGravedadInfraccion.SelectionStart = 0;
            this.labelGravedadInfraccion.ShortcutsEnabled = true;
            this.labelGravedadInfraccion.Size = new System.Drawing.Size(243, 48);
            this.labelGravedadInfraccion.SkipLiterals = true;
            this.labelGravedadInfraccion.TabIndex = 13;
            this.labelGravedadInfraccion.TabStop = false;
            this.labelGravedadInfraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelGravedadInfraccion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelGravedadInfraccion.TrailingIcon = null;
            this.labelGravedadInfraccion.UseAccent = false;
            this.labelGravedadInfraccion.UseSystemPasswordChar = false;
            this.labelGravedadInfraccion.ValidatingType = null;
            // 
            // labelNombre
            // 
            this.labelNombre.AllowPromptAsInput = true;
            this.labelNombre.AnimateReadOnly = false;
            this.labelNombre.AsciiOnly = false;
            this.labelNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelNombre.BeepOnError = false;
            this.labelNombre.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.labelNombre.Depth = 0;
            this.labelNombre.Enabled = false;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNombre.HidePromptOnLeave = false;
            this.labelNombre.HideSelection = true;
            this.labelNombre.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.labelNombre.LeadingIcon = null;
            this.labelNombre.Location = new System.Drawing.Point(529, 101);
            this.labelNombre.Mask = "";
            this.labelNombre.MaxLength = 32767;
            this.labelNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.PasswordChar = '\0';
            this.labelNombre.PrefixSuffixText = null;
            this.labelNombre.PromptChar = '_';
            this.labelNombre.ReadOnly = false;
            this.labelNombre.RejectInputOnFirstFailure = false;
            this.labelNombre.ResetOnPrompt = true;
            this.labelNombre.ResetOnSpace = true;
            this.labelNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombre.SelectedText = "";
            this.labelNombre.SelectionLength = 0;
            this.labelNombre.SelectionStart = 0;
            this.labelNombre.ShortcutsEnabled = true;
            this.labelNombre.Size = new System.Drawing.Size(299, 48);
            this.labelNombre.SkipLiterals = true;
            this.labelNombre.TabIndex = 14;
            this.labelNombre.TabStop = false;
            this.labelNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelNombre.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.labelNombre.TrailingIcon = null;
            this.labelNombre.UseAccent = false;
            this.labelNombre.UseSystemPasswordChar = false;
            this.labelNombre.ValidatingType = null;
            // 
            // infoBusquedaDominioVehiculo
            // 
            this.infoBusquedaDominioVehiculo.AutoSize = true;
            this.infoBusquedaDominioVehiculo.Depth = 0;
            this.infoBusquedaDominioVehiculo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoBusquedaDominioVehiculo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.infoBusquedaDominioVehiculo.Location = new System.Drawing.Point(44, 76);
            this.infoBusquedaDominioVehiculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoBusquedaDominioVehiculo.Name = "infoBusquedaDominioVehiculo";
            this.infoBusquedaDominioVehiculo.Size = new System.Drawing.Size(1, 0);
            this.infoBusquedaDominioVehiculo.TabIndex = 15;
            // 
            // administradoraBindingSource1
            // 
            this.administradoraBindingSource1.DataSource = typeof(CapaNegocio.Administradora);
            // 
            // administradoraBindingSource
            // 
            this.administradoraBindingSource.DataSource = typeof(CapaNegocio.Administradora);
            // 
            // AgregarInfraccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 503);
            this.Controls.Add(this.infoBusquedaDominioVehiculo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelGravedadInfraccion);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.labelDescInfraccion);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.labelDniPropietario);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.labelModeloVehiculo);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AgregarInfraccionVehiculo";
            this.Text = "Agregar Infraccion Vehículo";
            this.Load += new System.EventHandler(this.AgregarInfraccionVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administradoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox inputDominioVehiculo;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelModeloVehiculo;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.BindingSource administradoraBindingSource;
        private System.Windows.Forms.BindingSource administradoraBindingSource1;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelDniPropietario;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelImporte;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 labelDescInfraccion;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelGravedadInfraccion;
        private MaterialSkin.Controls.MaterialMaskedTextBox labelNombre;
        private MaterialSkin.Controls.MaterialLabel infoBusquedaDominioVehiculo;
    }
}