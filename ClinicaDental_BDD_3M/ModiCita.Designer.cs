namespace ClinicaDental_BDD_3M
{
    partial class ModiCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModiCita));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtGridDatosCitasAnt = new System.Windows.Forms.DataGridView();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTxtHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarCita = new System.Windows.Forms.Button();
            this.cmbtratamiento = new System.Windows.Forms.ComboBox();
            this.cmbodontologo = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.cmbIDCita = new System.Windows.Forms.ComboBox();
            this.dataCita = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosCitasAnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1030, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtGridDatosCitasAnt
            // 
            this.dtGridDatosCitasAnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDatosCitasAnt.Location = new System.Drawing.Point(33, 396);
            this.dtGridDatosCitasAnt.Name = "dtGridDatosCitasAnt";
            this.dtGridDatosCitasAnt.RowHeadersWidth = 62;
            this.dtGridDatosCitasAnt.RowTemplate.Height = 28;
            this.dtGridDatosCitasAnt.Size = new System.Drawing.Size(1105, 206);
            this.dtGridDatosCitasAnt.TabIndex = 28;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(204, 231);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(18, 20);
            this.lblCosto.TabIndex = 27;
            this.lblCosto.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Costo:";
            // 
            // mskTxtHora
            // 
            this.mskTxtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mskTxtHora.Location = new System.Drawing.Point(432, 321);
            this.mskTxtHora.Mask = "00:00";
            this.mskTxtHora.Name = "mskTxtHora";
            this.mskTxtHora.Size = new System.Drawing.Size(98, 48);
            this.mskTxtHora.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hora:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(371, 50);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tratamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Odontologo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paciente:";
            // 
            // btnRegistrarCita
            // 
            this.btnRegistrarCita.Location = new System.Drawing.Point(160, 320);
            this.btnRegistrarCita.Name = "btnRegistrarCita";
            this.btnRegistrarCita.Size = new System.Drawing.Size(159, 49);
            this.btnRegistrarCita.TabIndex = 19;
            this.btnRegistrarCita.Text = "Modificar cita";
            this.btnRegistrarCita.UseVisualStyleBackColor = true;
            this.btnRegistrarCita.Click += new System.EventHandler(this.btnRegistrarCita_Click);
            // 
            // cmbtratamiento
            // 
            this.cmbtratamiento.FormattingEnabled = true;
            this.cmbtratamiento.Location = new System.Drawing.Point(208, 169);
            this.cmbtratamiento.Name = "cmbtratamiento";
            this.cmbtratamiento.Size = new System.Drawing.Size(121, 28);
            this.cmbtratamiento.TabIndex = 18;
            // 
            // cmbodontologo
            // 
            this.cmbodontologo.FormattingEnabled = true;
            this.cmbodontologo.Location = new System.Drawing.Point(208, 131);
            this.cmbodontologo.Name = "cmbodontologo";
            this.cmbodontologo.Size = new System.Drawing.Size(121, 28);
            this.cmbodontologo.TabIndex = 17;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(208, 88);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(121, 28);
            this.cmbPaciente.TabIndex = 16;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(204, 272);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(18, 20);
            this.lblTiempo.TabIndex = 31;
            this.lblTiempo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tiempo estimado:";
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.Location = new System.Drawing.Point(747, 50);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(159, 49);
            this.btnGuardarCita.TabIndex = 32;
            this.btnGuardarCita.Text = "Guardar cita";
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // cmbIDCita
            // 
            this.cmbIDCita.FormattingEnabled = true;
            this.cmbIDCita.Location = new System.Drawing.Point(33, 331);
            this.cmbIDCita.Name = "cmbIDCita";
            this.cmbIDCita.Size = new System.Drawing.Size(121, 28);
            this.cmbIDCita.TabIndex = 33;
            // 
            // dataCita
            // 
            this.dataCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCita.Location = new System.Drawing.Point(747, 242);
            this.dataCita.Name = "dataCita";
            this.dataCita.RowHeadersWidth = 62;
            this.dataCita.RowTemplate.Height = 28;
            this.dataCita.Size = new System.Drawing.Size(391, 127);
            this.dataCita.TabIndex = 34;
            // 
            // ModiCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1164, 625);
            this.Controls.Add(this.dataCita);
            this.Controls.Add(this.cmbIDCita);
            this.Controls.Add(this.btnGuardarCita);
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
            this.Name = "ModiCita";
            this.Text = "ModiCita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDatosCitasAnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtGridDatosCitasAnt;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTxtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarCita;
        private System.Windows.Forms.ComboBox cmbtratamiento;
        private System.Windows.Forms.ComboBox cmbodontologo;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarCita;
        private System.Windows.Forms.ComboBox cmbIDCita;
        private System.Windows.Forms.DataGridView dataCita;
    }
}