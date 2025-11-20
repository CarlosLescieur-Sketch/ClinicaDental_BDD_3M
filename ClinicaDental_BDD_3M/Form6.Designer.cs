namespace ClinicaDental_BDD_3M
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbodontologo = new System.Windows.Forms.ComboBox();
            this.cmbtratamiento = new System.Windows.Forms.ComboBox();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.dtGridDatosCitasAnt = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosCitasAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(191, 54);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 28);
            this.cmbPaciente.TabIndex = 0;
            // 
            // cmbodontologo
            // 
            this.cmbodontologo.FormattingEnabled = true;
            this.cmbodontologo.Location = new System.Drawing.Point(191, 114);
            this.cmbodontologo.Name = "cmbodontologo";
            this.cmbodontologo.Size = new System.Drawing.Size(121, 28);
            this.cmbodontologo.TabIndex = 1;
            // 
            // cmbtratamiento
            // 
            this.cmbtratamiento.FormattingEnabled = true;
            this.cmbtratamiento.Location = new System.Drawing.Point(191, 173);
            this.cmbtratamiento.Name = "cmbtratamiento";
            this.cmbtratamiento.Size = new System.Drawing.Size(121, 28);
            this.cmbtratamiento.TabIndex = 2;
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Location = new System.Drawing.Point(97, 324);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(159, 49);
            this.btnRegistrarCita.TabIndex = 3;
            this.btnRegistrarCita.Text = "Registrar cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odontologo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tratamiento:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(354, 54);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora:";
            // 
            // mskTxtHora
            // 
            this.mskTxtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mskTxtHora.Location = new System.Drawing.Point(415, 325);
            this.mskTxtHora.Mask = "00:00";
            this.mskTxtHora.Name = "mskTxtHora";
            this.mskTxtHora.Size = new System.Drawing.Size(98, 48);
            this.mskTxtHora.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Costo:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(187, 235);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(18, 20);
            this.lblCosto.TabIndex = 13;
            this.lblCosto.Text = "0";
            // 
            // dtGridDatosCitasAnt
            // 
            this.dtGridDatosCitasAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDatosCitasAnt.Location = new System.Drawing.Point(16, 400);
            this.dtGridDatosCitasAnt.Name = "dtGridDatosCitasAnt";
            this.dtGridDatosCitasAnt.RowHeadersWidth = 62;
            this.dtGridDatosCitasAnt.RowTemplate.Height = 28;
            this.dtGridDatosCitasAnt.Size = new System.Drawing.Size(988, 206);
            this.dtGridDatosCitasAnt.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(187, 270);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(18, 20);
            this.lblTiempo.TabIndex = 17;
            this.lblTiempo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tiempo estimado:";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1016, 618);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridDatosCitasAnt);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskTxtHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarCita);
            this.Controls.Add(this.cmbtratamiento);
            this.Controls.Add(this.cmbodontologo);
            this.Controls.Add(this.cmbPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Registro de cita";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosCitasAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbodontologo;
        private System.Windows.Forms.ComboBox cmbtratamiento;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTxtHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.DataGridView dtGridDatosCitasAnt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label7;
    }
}