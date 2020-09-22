namespace DiseñoVisualBD
{
    partial class Clientes
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AtrasButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LabelDeGuardadoExitoso = new System.Windows.Forms.Label();
            this.NombreClientesTextBox = new System.Windows.Forms.TextBox();
            this.FechaNacClientePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(81, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(207, 18);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Declare los Datos a Guardar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // AtrasButton
            // 
            this.AtrasButton.Location = new System.Drawing.Point(33, 206);
            this.AtrasButton.Name = "AtrasButton";
            this.AtrasButton.Size = new System.Drawing.Size(75, 23);
            this.AtrasButton.TabIndex = 3;
            this.AtrasButton.Text = "Atras";
            this.AtrasButton.UseVisualStyleBackColor = true;
            this.AtrasButton.Click += new System.EventHandler(this.AtrasButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(152, 206);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(270, 206);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LabelDeGuardadoExitoso
            // 
            this.LabelDeGuardadoExitoso.AutoSize = true;
            this.LabelDeGuardadoExitoso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeGuardadoExitoso.Location = new System.Drawing.Point(68, 151);
            this.LabelDeGuardadoExitoso.Name = "LabelDeGuardadoExitoso";
            this.LabelDeGuardadoExitoso.Size = new System.Drawing.Size(238, 20);
            this.LabelDeGuardadoExitoso.TabIndex = 6;
            this.LabelDeGuardadoExitoso.Text = "Los datos se han guardado con exito";
            this.LabelDeGuardadoExitoso.Visible = false;
            // 
            // NombreClientesTextBox
            // 
            this.NombreClientesTextBox.Location = new System.Drawing.Point(166, 54);
            this.NombreClientesTextBox.Name = "NombreClientesTextBox";
            this.NombreClientesTextBox.Size = new System.Drawing.Size(179, 20);
            this.NombreClientesTextBox.TabIndex = 7;
            // 
            // FechaNacClientePicker
            // 
            this.FechaNacClientePicker.Location = new System.Drawing.Point(166, 96);
            this.FechaNacClientePicker.Name = "FechaNacClientePicker";
            this.FechaNacClientePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaNacClientePicker.TabIndex = 8;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.FechaNacClientePicker);
            this.Controls.Add(this.NombreClientesTextBox);
            this.Controls.Add(this.LabelDeGuardadoExitoso);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.AtrasButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AtrasButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label LabelDeGuardadoExitoso;
        private System.Windows.Forms.TextBox NombreClientesTextBox;
        private System.Windows.Forms.DateTimePicker FechaNacClientePicker;
    }
}