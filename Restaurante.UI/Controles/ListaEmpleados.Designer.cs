namespace Restaurante.UI.Controles
{
    partial class ListaEmpleados
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(0, 0);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(285, 21);
            this.cmbEmpleados.TabIndex = 0;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(4, 28);
            this.txtNombreEmpleado.Name = "textBox1";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(278, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // ListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.cmbEmpleados);
            this.Name = "ListaEmpleados";
            this.Size = new System.Drawing.Size(285, 111);
            this.Load += new System.EventHandler(this.ListaEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
    }
}
