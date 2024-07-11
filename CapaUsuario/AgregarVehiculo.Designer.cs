namespace Sistema_Infracciones
{
    partial class AgregarVehiculo
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
            this.inputDominioVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.inputDNIPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputModeloVehiculo = new MaterialSkin.Controls.MaterialTextBox();
            this.botonGuardar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // inputDominioVehiculo
            // 
            this.inputDominioVehiculo.AnimateReadOnly = false;
            this.inputDominioVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDominioVehiculo.Depth = 0;
            this.inputDominioVehiculo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDominioVehiculo.Hint = "Dominio";
            this.inputDominioVehiculo.LeadingIcon = null;
            this.inputDominioVehiculo.Location = new System.Drawing.Point(61, 102);
            this.inputDominioVehiculo.MaxLength = 50;
            this.inputDominioVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDominioVehiculo.Multiline = false;
            this.inputDominioVehiculo.Name = "inputDominioVehiculo";
            this.inputDominioVehiculo.Size = new System.Drawing.Size(195, 50);
            this.inputDominioVehiculo.TabIndex = 0;
            this.inputDominioVehiculo.Text = "";
            this.inputDominioVehiculo.TrailingIcon = null;
            this.inputDominioVehiculo.TextChanged += new System.EventHandler(this.inputDominioVehiculo_TextChanged);
            // 
            // inputDNIPropietario
            // 
            this.inputDNIPropietario.AnimateReadOnly = false;
            this.inputDNIPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDNIPropietario.Depth = 0;
            this.inputDNIPropietario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputDNIPropietario.Hint = "DNI Propietario";
            this.inputDNIPropietario.LeadingIcon = null;
            this.inputDNIPropietario.Location = new System.Drawing.Point(61, 259);
            this.inputDNIPropietario.MaxLength = 50;
            this.inputDNIPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputDNIPropietario.Multiline = false;
            this.inputDNIPropietario.Name = "inputDNIPropietario";
            this.inputDNIPropietario.Size = new System.Drawing.Size(195, 50);
            this.inputDNIPropietario.TabIndex = 1;
            this.inputDNIPropietario.Text = "";
            this.inputDNIPropietario.TrailingIcon = null;
            // 
            // inputModeloVehiculo
            // 
            this.inputModeloVehiculo.AnimateReadOnly = false;
            this.inputModeloVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputModeloVehiculo.Depth = 0;
            this.inputModeloVehiculo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputModeloVehiculo.Hint = "Modelo";
            this.inputModeloVehiculo.LeadingIcon = null;
            this.inputModeloVehiculo.Location = new System.Drawing.Point(61, 180);
            this.inputModeloVehiculo.MaxLength = 50;
            this.inputModeloVehiculo.MouseState = MaterialSkin.MouseState.OUT;
            this.inputModeloVehiculo.Multiline = false;
            this.inputModeloVehiculo.Name = "inputModeloVehiculo";
            this.inputModeloVehiculo.Size = new System.Drawing.Size(195, 50);
            this.inputModeloVehiculo.TabIndex = 2;
            this.inputModeloVehiculo.Text = "";
            this.inputModeloVehiculo.TrailingIcon = null;
            // 
            // botonGuardar
            // 
            this.botonGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botonGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.botonGuardar.Depth = 0;
            this.botonGuardar.HighEmphasis = true;
            this.botonGuardar.Icon = null;
            this.botonGuardar.Location = new System.Drawing.Point(61, 327);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.botonGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.botonGuardar.Size = new System.Drawing.Size(88, 36);
            this.botonGuardar.TabIndex = 3;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.botonGuardar.UseAccentColor = false;
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // AgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.inputModeloVehiculo);
            this.Controls.Add(this.inputDNIPropietario);
            this.Controls.Add(this.inputDominioVehiculo);
            this.Name = "AgregarVehiculo";
            this.Text = "AgregarVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox inputDominioVehiculo;
        private MaterialSkin.Controls.MaterialTextBox inputDNIPropietario;
        private MaterialSkin.Controls.MaterialTextBox inputModeloVehiculo;
        private MaterialSkin.Controls.MaterialButton botonGuardar;
    }
}