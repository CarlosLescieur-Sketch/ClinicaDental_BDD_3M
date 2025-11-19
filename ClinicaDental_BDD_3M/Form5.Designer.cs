namespace ClinicaDental_BDD_3M
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.txtNombreTratNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtDescripcionTrataNew = new System.Windows.Forms.TextBox();
            this.btnRegTrataNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoTrataNew = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreTratNew
            // 
            this.txtNombreTratNew.Location = new System.Drawing.Point(273, 80);
            this.txtNombreTratNew.Name = "txtNombreTratNew";
            this.txtNombreTratNew.Size = new System.Drawing.Size(121, 26);
            this.txtNombreTratNew.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especialidad que lo puede realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(273, 33);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 28);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // txtDescripcionTrataNew
            // 
            this.txtDescripcionTrataNew.Location = new System.Drawing.Point(273, 131);
            this.txtDescripcionTrataNew.Name = "txtDescripcionTrataNew";
            this.txtDescripcionTrataNew.Size = new System.Drawing.Size(121, 26);
            this.txtDescripcionTrataNew.TabIndex = 6;
            // 
            // btnRegTrataNew
            // 
            this.btnRegTrataNew.Location = new System.Drawing.Point(134, 282);
            this.btnRegTrataNew.Name = "btnRegTrataNew";
            this.btnRegTrataNew.Size = new System.Drawing.Size(170, 59);
            this.btnRegTrataNew.TabIndex = 8;
            this.btnRegTrataNew.Text = "Registrat nuevo tratamiento";
            this.btnRegTrataNew.UseVisualStyleBackColor = true;
            this.btnRegTrataNew.Click += new System.EventHandler(this.btnRegTrataNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo: ";
            // 
            // txtCostoTrataNew
            // 
            this.txtCostoTrataNew.Location = new System.Drawing.Point(273, 171);
            this.txtCostoTrataNew.Name = "txtCostoTrataNew";
            this.txtCostoTrataNew.Size = new System.Drawing.Size(121, 26);
            this.txtCostoTrataNew.TabIndex = 7;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(273, 216);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(121, 26);
            this.txtTiempo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tiempo estimado: ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(590, 369);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegTrataNew);
            this.Controls.Add(this.txtCostoTrataNew);
            this.Controls.Add(this.txtDescripcionTrataNew);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreTratNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Registro de nuevos Tratamientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTratNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtDescripcionTrataNew;
        private System.Windows.Forms.Button btnRegTrataNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostoTrataNew;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label5;
    }
}