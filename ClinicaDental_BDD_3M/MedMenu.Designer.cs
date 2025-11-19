namespace ClinicaDental_BDD_3M
{
    partial class MedMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedMenu));
            this.cmbMed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpaciAAtender = new System.Windows.Forms.ComboBox();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnDelPac = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMed
            // 
            this.cmbMed.FormattingEnabled = true;
            this.cmbMed.Location = new System.Drawing.Point(290, 45);
            this.cmbMed.Name = "cmbMed";
            this.cmbMed.Size = new System.Drawing.Size(121, 28);
            this.cmbMed.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el medico que es";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el paciente que atendera";
            // 
            // cmbpaciAAtender
            // 
            this.cmbpaciAAtender.FormattingEnabled = true;
            this.cmbpaciAAtender.Location = new System.Drawing.Point(290, 88);
            this.cmbpaciAAtender.Name = "cmbpaciAAtender";
            this.cmbpaciAAtender.Size = new System.Drawing.Size(121, 28);
            this.cmbpaciAAtender.TabIndex = 4;
            // 
            // btnAtendido
            // 
            this.btnAtendido.Location = new System.Drawing.Point(503, 49);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(129, 59);
            this.btnAtendido.TabIndex = 5;
            this.btnAtendido.Text = "Paciente atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelPac
            // 
            this.btnDelPac.Location = new System.Drawing.Point(673, 49);
            this.btnDelPac.Name = "btnDelPac";
            this.btnDelPac.Size = new System.Drawing.Size(129, 59);
            this.btnDelPac.TabIndex = 6;
            this.btnDelPac.Text = "Eliminar Paciente";
            this.btnDelPac.UseVisualStyleBackColor = true;
            this.btnDelPac.Click += new System.EventHandler(this.btnDelPac_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MedMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(872, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelPac);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.cmbpaciAAtender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedMenu";
            this.Text = "MedMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpaciAAtender;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnDelPac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}