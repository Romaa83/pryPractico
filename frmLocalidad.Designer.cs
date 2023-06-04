namespace pryPractico
{
    partial class frmLocalidad
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
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIngreseNumero = new System.Windows.Forms.Label();
            this.txtNumeroLocalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.Location = new System.Drawing.Point(24, 80);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(100, 25);
            this.lblIngreseNombre.TabIndex = 0;
            this.lblIngreseNombre.Text = "Nombre:";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLocalidad.Location = new System.Drawing.Point(142, 77);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(178, 31);
            this.txtNombreLocalidad.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(183, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblIngreseNumero
            // 
            this.lblIngreseNumero.AutoSize = true;
            this.lblIngreseNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNumero.Location = new System.Drawing.Point(24, 33);
            this.lblIngreseNumero.Name = "lblIngreseNumero";
            this.lblIngreseNumero.Size = new System.Drawing.Size(100, 25);
            this.lblIngreseNumero.TabIndex = 5;
            this.lblIngreseNumero.Text = "Numero:";
            // 
            // txtNumeroLocalidad
            // 
            this.txtNumeroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroLocalidad.Location = new System.Drawing.Point(142, 30);
            this.txtNumeroLocalidad.Name = "txtNumeroLocalidad";
            this.txtNumeroLocalidad.Size = new System.Drawing.Size(178, 31);
            this.txtNumeroLocalidad.TabIndex = 6;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 213);
            this.Controls.Add(this.txtNumeroLocalidad);
            this.Controls.Add(this.lblIngreseNumero);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblIngreseNombre);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIngreseNumero;
        private System.Windows.Forms.TextBox txtNumeroLocalidad;
    }
}