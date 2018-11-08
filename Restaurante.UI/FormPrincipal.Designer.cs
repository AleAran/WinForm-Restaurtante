namespace Restaurante.UI
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atenciònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionEmpleados1 = new Restaurante.UI.Controles.SeleccionEmpleados();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.atenciònToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.mesasToolStripMenuItem,
            this.platosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // platosToolStripMenuItem
            // 
            this.platosToolStripMenuItem.Name = "platosToolStripMenuItem";
            this.platosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.platosToolStripMenuItem.Text = "Platos";
            this.platosToolStripMenuItem.Click += new System.EventHandler(this.platosToolStripMenuItem_Click);
            // 
            // atenciònToolStripMenuItem
            // 
            this.atenciònToolStripMenuItem.Name = "atenciònToolStripMenuItem";
            this.atenciònToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.atenciònToolStripMenuItem.Text = "Atenciòn";
            this.atenciònToolStripMenuItem.Click += new System.EventHandler(this.atenciònToolStripMenuItem_Click);
            // 
            // seleccionEmpleados1
            // 
            this.seleccionEmpleados1.Location = new System.Drawing.Point(0, 27);
            this.seleccionEmpleados1.Name = "seleccionEmpleados1";
            this.seleccionEmpleados1.Size = new System.Drawing.Size(292, 246);
            this.seleccionEmpleados1.TabIndex = 3;
            this.seleccionEmpleados1.Load += new System.EventHandler(this.seleccionEmpleados1_Load);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.seleccionEmpleados1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atenciònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem platosToolStripMenuItem;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private Controles.SeleccionEmpleados seleccionEmpleados1;
    }
}

