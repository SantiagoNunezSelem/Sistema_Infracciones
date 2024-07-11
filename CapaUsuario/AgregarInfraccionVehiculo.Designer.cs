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
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.labelDescInfraccion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.infoBusquedaDominioVehiculo = new MaterialSkin.Controls.MaterialLabel();
            this.administradoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.administradoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputModeloVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDNIPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputNombreInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputInporte = new MaterialSkin.Controls.MaterialTextBox();
            this.inputGravedadInfraccion = new MaterialSkin.Controls.MaterialTextBox();
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
            this.materialComboBox1.Hint = "Codigo Infracción";
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
            // labelDescInfraccion
            // 
            this.labelDescInfraccion.AnimateReadOnly = false;
            this.labelDescInfraccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.labelDescInfraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.labelDescInfraccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDescInfraccion.Depth = 0;
            this.labelDescInfraccion.Enabled = false;
            this.labelDescInfraccion.HideSelection = true;
            this.labelDescInfraccion.Hint = "Descripcion";
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
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
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
            // inputModeloVehiculo
            // 
            this.inputModeloVehiculo.AnimateReadOnly = false;
            this.inputModeloVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputModeloVehiculo.Depth = 0;
            this.inputModeloVehiculo.Enabled = false;
            this.inputModeloVehiculo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputModeloVehiculo.Hint = "Modelo";
            this.inputModeloVehiculo.LeadingIcon = null;
            this.inputModeloVehiculo.Location = new System.Drawing.Point(41, 170);
            this.inputModeloVehiculo.MaxLength = 50;
            this.inputModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputModeloVehiculo.Multiline = false;
            this.inputModeloVehiculo.Name = "inputModeloVehiculo";
            this.inputModeloVehiculo.Size = new System.Drawing.Size(223, 50);
            this.inputModeloVehiculo.TabIndex = 23;
            this.inputModeloVehiculo.Text = "";
            this.inputModeloVehiculo.TrailingIcon = null;
            // 
            // inputDNIPropietario
            // 
            this.inputDNIPropietario.AnimateReadOnly = false;
            this.inputDNIPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDNIPropietario.Depth = 0;
            this.inputDNIPropietario.Enabled = false;
            this.inputDNIPropietario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDNIPropietario.Hint = "DNI Propietario";
            this.inputDNIPropietario.LeadingIcon = null;
            this.inputDNIPropietario.Location = new System.Drawing.Point(41, 245);
            this.inputDNIPropietario.MaxLength = 50;
            this.inputDNIPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDNIPropietario.Multiline = false;
            this.inputDNIPropietario.Name = "inputDNIPropietario";
            this.inputDNIPropietario.Size = new System.Drawing.Size(223, 50);
            this.inputDNIPropietario.TabIndex = 22;
            this.inputDNIPropietario.Text = "";
            this.inputDNIPropietario.TrailingIcon = null;
            // 
            // inputNombreInfraccion
            // 
            this.inputNombreInfraccion.AnimateReadOnly = false;
            this.inputNombreInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNombreInfraccion.Depth = 0;
            this.inputNombreInfraccion.Enabled = false;
            this.inputNombreInfraccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputNombreInfraccion.Hint = "Nombre Infraccion";
            this.inputNombreInfraccion.LeadingIcon = null;
            this.inputNombreInfraccion.Location = new System.Drawing.Point(529, 100);
            this.inputNombreInfraccion.MaxLength = 50;
            this.inputNombreInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNombreInfraccion.Multiline = false;
            this.inputNombreInfraccion.Name = "inputNombreInfraccion";
            this.inputNombreInfraccion.Size = new System.Drawing.Size(299, 50);
            this.inputNombreInfraccion.TabIndex = 24;
            this.inputNombreInfraccion.Text = "";
            this.inputNombreInfraccion.TrailingIcon = null;
            // 
            // inputInporte
            // 
            this.inputInporte.AnimateReadOnly = false;
            this.inputInporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputInporte.Depth = 0;
            this.inputInporte.Enabled = false;
            this.inputInporte.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputInporte.Hint = "Importe";
            this.inputInporte.LeadingIcon = null;
            this.inputInporte.Location = new System.Drawing.Point(330, 316);
            this.inputInporte.MaxLength = 50;
            this.inputInporte.MouseState = MaterialSkin.MouseState.OUT;
            this.inputInporte.Multiline = false;
            this.inputInporte.Name = "inputInporte";
            this.inputInporte.Size = new System.Drawing.Size(239, 50);
            this.inputInporte.TabIndex = 25;
            this.inputInporte.Text = "";
            this.inputInporte.TrailingIcon = null;
            // 
            // inputGravedadInfraccion
            // 
            this.inputGravedadInfraccion.AnimateReadOnly = false;
            this.inputGravedadInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputGravedadInfraccion.Depth = 0;
            this.inputGravedadInfraccion.Enabled = false;
            this.inputGravedadInfraccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputGravedadInfraccion.Hint = "Gravedad de la Infraccion";
            this.inputGravedadInfraccion.LeadingIcon = null;
            this.inputGravedadInfraccion.Location = new System.Drawing.Point(587, 316);
            this.inputGravedadInfraccion.MaxLength = 50;
            this.inputGravedadInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputGravedadInfraccion.Multiline = false;
            this.inputGravedadInfraccion.Name = "inputGravedadInfraccion";
            this.inputGravedadInfraccion.Size = new System.Drawing.Size(241, 50);
            this.inputGravedadInfraccion.TabIndex = 26;
            this.inputGravedadInfraccion.Text = "";
            this.inputGravedadInfraccion.TrailingIcon = null;
            // 
            // AgregarInfraccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 503);
            this.Controls.Add(this.inputGravedadInfraccion);
            this.Controls.Add(this.inputInporte);
            this.Controls.Add(this.inputNombreInfraccion);
            this.Controls.Add(this.inputModeloVehiculo);
            this.Controls.Add(this.inputDNIPropietario);
            this.Controls.Add(this.infoBusquedaDominioVehiculo);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.labelDescInfraccion);
            this.Controls.Add(this.materialComboBox1);
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
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.BindingSource administradoraBindingSource;
        private System.Windows.Forms.BindingSource administradoraBindingSource1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 labelDescInfraccion;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel infoBusquedaDominioVehiculo;
        private MaterialSkin.Controls.MaterialTextBox inputModeloVehiculo;
        private MaterialSkin.Controls.MaterialTextBox inputDNIPropietario;
        private MaterialSkin.Controls.MaterialTextBox inputNombreInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputInporte;
        private MaterialSkin.Controls.MaterialTextBox inputGravedadInfraccion;
    }
}