namespace Sistema_Infracciones
{
    partial class AgregarNuevoTipoInfraccion
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
            this.inputCodigoInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputNombreInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputImporteInfraccion = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDescInfraccion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.botonRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.inputGravedadInfraccion = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // inputCodigoInfraccion
            // 
            this.inputCodigoInfraccion.AnimateReadOnly = false;
            this.inputCodigoInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCodigoInfraccion.Depth = 0;
            this.inputCodigoInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputCodigoInfraccion.Hint = "Codigo Infracción";
            this.inputCodigoInfraccion.LeadingIcon = null;
            this.inputCodigoInfraccion.Location = new System.Drawing.Point(45, 102);
            this.inputCodigoInfraccion.MaxLength = 50;
            this.inputCodigoInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputCodigoInfraccion.Multiline = false;
            this.inputCodigoInfraccion.Name = "inputCodigoInfraccion";
            this.inputCodigoInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputCodigoInfraccion.TabIndex = 36;
            this.inputCodigoInfraccion.Text = "";
            this.inputCodigoInfraccion.TrailingIcon = null;
            this.inputCodigoInfraccion.TextChanged += new System.EventHandler(this.inputCodigoInfraccion_TextChanged);
            // 
            // inputNombreInfraccion
            // 
            this.inputNombreInfraccion.AnimateReadOnly = false;
            this.inputNombreInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNombreInfraccion.Depth = 0;
            this.inputNombreInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputNombreInfraccion.Hint = "Nombre Infracción";
            this.inputNombreInfraccion.LeadingIcon = null;
            this.inputNombreInfraccion.Location = new System.Drawing.Point(45, 174);
            this.inputNombreInfraccion.MaxLength = 50;
            this.inputNombreInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputNombreInfraccion.Multiline = false;
            this.inputNombreInfraccion.Name = "inputNombreInfraccion";
            this.inputNombreInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputNombreInfraccion.TabIndex = 35;
            this.inputNombreInfraccion.Text = "";
            this.inputNombreInfraccion.TrailingIcon = null;
            // 
            // inputImporteInfraccion
            // 
            this.inputImporteInfraccion.AnimateReadOnly = false;
            this.inputImporteInfraccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputImporteInfraccion.Depth = 0;
            this.inputImporteInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputImporteInfraccion.Hint = "Importe Infracción";
            this.inputImporteInfraccion.LeadingIcon = null;
            this.inputImporteInfraccion.Location = new System.Drawing.Point(311, 174);
            this.inputImporteInfraccion.MaxLength = 50;
            this.inputImporteInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputImporteInfraccion.Multiline = false;
            this.inputImporteInfraccion.Name = "inputImporteInfraccion";
            this.inputImporteInfraccion.Size = new System.Drawing.Size(223, 50);
            this.inputImporteInfraccion.TabIndex = 38;
            this.inputImporteInfraccion.Text = "";
            this.inputImporteInfraccion.TrailingIcon = null;
            // 
            // inputDescInfraccion
            // 
            this.inputDescInfraccion.AnimateReadOnly = false;
            this.inputDescInfraccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inputDescInfraccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.inputDescInfraccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDescInfraccion.Depth = 0;
            this.inputDescInfraccion.HideSelection = true;
            this.inputDescInfraccion.Hint = "Descripcion";
            this.inputDescInfraccion.Location = new System.Drawing.Point(45, 251);
            this.inputDescInfraccion.MaxLength = 32767;
            this.inputDescInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDescInfraccion.Name = "inputDescInfraccion";
            this.inputDescInfraccion.PasswordChar = '\0';
            this.inputDescInfraccion.ReadOnly = false;
            this.inputDescInfraccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputDescInfraccion.SelectedText = "";
            this.inputDescInfraccion.SelectionLength = 0;
            this.inputDescInfraccion.SelectionStart = 0;
            this.inputDescInfraccion.ShortcutsEnabled = true;
            this.inputDescInfraccion.Size = new System.Drawing.Size(489, 119);
            this.inputDescInfraccion.TabIndex = 39;
            this.inputDescInfraccion.TabStop = false;
            this.inputDescInfraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputDescInfraccion.UseSystemPasswordChar = false;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.botonRegistrar.Depth = 0;
            this.botonRegistrar.HighEmphasis = true;
            this.botonRegistrar.Icon = null;
            this.botonRegistrar.Location = new System.Drawing.Point(45, 392);
            this.botonRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.botonRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.botonRegistrar.Size = new System.Drawing.Size(99, 36);
            this.botonRegistrar.TabIndex = 40;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.botonRegistrar.UseAccentColor = false;
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // inputGravedadInfraccion
            // 
            this.inputGravedadInfraccion.AutoResize = false;
            this.inputGravedadInfraccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.inputGravedadInfraccion.Depth = 0;
            this.inputGravedadInfraccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.inputGravedadInfraccion.DropDownHeight = 174;
            this.inputGravedadInfraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputGravedadInfraccion.DropDownWidth = 121;
            this.inputGravedadInfraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.inputGravedadInfraccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputGravedadInfraccion.FormattingEnabled = true;
            this.inputGravedadInfraccion.Hint = "Gravedad Infracción";
            this.inputGravedadInfraccion.IntegralHeight = false;
            this.inputGravedadInfraccion.ItemHeight = 43;
            this.inputGravedadInfraccion.Items.AddRange(new object[] {
            "Infraccion Leve",
            "Infraccion Grave"});
            this.inputGravedadInfraccion.Location = new System.Drawing.Point(311, 103);
            this.inputGravedadInfraccion.MaxDropDownItems = 4;
            this.inputGravedadInfraccion.MouseState = MaterialSkin.MouseState.OUT;
            this.inputGravedadInfraccion.Name = "inputGravedadInfraccion";
            this.inputGravedadInfraccion.Size = new System.Drawing.Size(223, 49);
            this.inputGravedadInfraccion.StartIndex = 0;
            this.inputGravedadInfraccion.TabIndex = 41;
            // 
            // AgregarNuevoTipoInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputGravedadInfraccion);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.inputDescInfraccion);
            this.Controls.Add(this.inputImporteInfraccion);
            this.Controls.Add(this.inputCodigoInfraccion);
            this.Controls.Add(this.inputNombreInfraccion);
            this.Name = "AgregarNuevoTipoInfraccion";
            this.Text = "Agregar Nuevo Tipo Infraccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox inputCodigoInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputNombreInfraccion;
        private MaterialSkin.Controls.MaterialTextBox inputImporteInfraccion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 inputDescInfraccion;
        private MaterialSkin.Controls.MaterialButton botonRegistrar;
        private MaterialSkin.Controls.MaterialComboBox inputGravedadInfraccion;
    }
}