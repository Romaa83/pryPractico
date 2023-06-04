namespace pryPractico
{
    partial class frmProfesion
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
            this.txtNumeroProfesion = new System.Windows.Forms.TextBox();
            this.lblIngreseNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreProfesion = new System.Windows.Forms.TextBox();
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroProfesion
            // 
            this.txtNumeroProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroProfesion.Location = new System.Drawing.Point(142, 21);
            this.txtNumeroProfesion.Name = "txtNumeroProfesion";
            this.txtNumeroProfesion.Size = new System.Drawing.Size(178, 31);
            this.txtNumeroProfesion.TabIndex = 11;
            // 
            // lblIngreseNumero
            // 
            this.lblIngreseNumero.AutoSize = true;
            this.lblIngreseNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNumero.Location = new System.Drawing.Point(24, 24);
            this.lblIngreseNumero.Name = "lblIngreseNumero";
            this.lblIngreseNumero.Size = new System.Drawing.Size(100, 25);
            this.lblIngreseNumero.TabIndex = 10;
            this.lblIngreseNumero.Text = "Numero:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(183, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 36);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombreProfesion
            // 
            this.txtNombreProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProfesion.Location = new System.Drawing.Point(142, 68);
            this.txtNombreProfesion.Name = "txtNombreProfesion";
            this.txtNombreProfesion.Size = new System.Drawing.Size(178, 31);
            this.txtNombreProfesion.TabIndex = 8;
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.Location = new System.Drawing.Point(24, 71);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(100, 25);
            this.lblIngreseNombre.TabIndex = 7;
            this.lblIngreseNombre.Text = "Nombre:";
            // 
            // frmProfesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 203);
            this.Controls.Add(this.txtNumeroProfesion);
            this.Controls.Add(this.lblIngreseNumero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreProfesion);
            this.Controls.Add(this.lblIngreseNombre);
            this.Name = "frmProfesion";
            this.Text = "frmProfesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroProfesion;
        private System.Windows.Forms.Label lblIngreseNumero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreProfesion;
        private System.Windows.Forms.Label lblIngreseNombre;
    }
}