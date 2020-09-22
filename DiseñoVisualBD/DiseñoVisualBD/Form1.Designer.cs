namespace DiseñoVisualBD
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClienteButton = new System.Windows.Forms.Button();
            this.ProveedoresButton = new System.Windows.Forms.Button();
            this.ProductoButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.LabelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClienteButton
            // 
            this.ClienteButton.Location = new System.Drawing.Point(144, 39);
            this.ClienteButton.Name = "ClienteButton";
            this.ClienteButton.Size = new System.Drawing.Size(100, 50);
            this.ClienteButton.TabIndex = 0;
            this.ClienteButton.Text = "Clientes";
            this.ClienteButton.UseVisualStyleBackColor = true;
            this.ClienteButton.Click += new System.EventHandler(this.ClienteButton_Click);
            // 
            // ProveedoresButton
            // 
            this.ProveedoresButton.Location = new System.Drawing.Point(144, 95);
            this.ProveedoresButton.Name = "ProveedoresButton";
            this.ProveedoresButton.Size = new System.Drawing.Size(100, 50);
            this.ProveedoresButton.TabIndex = 1;
            this.ProveedoresButton.Text = "Proveedores";
            this.ProveedoresButton.UseVisualStyleBackColor = true;
            this.ProveedoresButton.Click += new System.EventHandler(this.ProveedoresButton_Click);
            // 
            // ProductoButton
            // 
            this.ProductoButton.Location = new System.Drawing.Point(144, 151);
            this.ProductoButton.Name = "ProductoButton";
            this.ProductoButton.Size = new System.Drawing.Size(100, 50);
            this.ProductoButton.TabIndex = 2;
            this.ProductoButton.Text = "Producto";
            this.ProductoButton.UseVisualStyleBackColor = true;
            this.ProductoButton.Click += new System.EventHandler(this.ProductoButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(285, 206);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // LabelMenu
            // 
            this.LabelMenu.AutoSize = true;
            this.LabelMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMenu.Location = new System.Drawing.Point(102, 9);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(180, 18);
            this.LabelMenu.TabIndex = 4;
            this.LabelMenu.Text = "¿A que menu Deseas Ir?";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.LabelMenu);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ProductoButton);
            this.Controls.Add(this.ProveedoresButton);
            this.Controls.Add(this.ClienteButton);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClienteButton;
        private System.Windows.Forms.Button ProveedoresButton;
        private System.Windows.Forms.Button ProductoButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Label LabelMenu;
    }
}

