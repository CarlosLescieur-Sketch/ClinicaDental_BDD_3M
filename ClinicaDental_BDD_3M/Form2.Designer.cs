namespace ClinicaDental_BDD_3M
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoIngrPac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModCitaF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELIGE LA OPCION QUE DESEAS EJECUTAR";
            // 
            // btnNuevoIngrPac
            // 
            this.btnNuevoIngrPac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoIngrPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoIngrPac.Location = new System.Drawing.Point(80, 95);
            this.btnNuevoIngrPac.Name = "btnNuevoIngrPac";
            this.btnNuevoIngrPac.Size = new System.Drawing.Size(187, 84);
            this.btnNuevoIngrPac.TabIndex = 1;
            this.btnNuevoIngrPac.Text = "Ingresar nuevo paciente";
            this.btnNuevoIngrPac.UseVisualStyleBackColor = true;
            this.btnNuevoIngrPac.Click += new System.EventHandler(this.btnNuevoIngrPac_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar registro de paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModCitaF
            // 
            this.btnModCitaF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModCitaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCitaF.Location = new System.Drawing.Point(541, 95);
            this.btnModCitaF.Name = "btnModCitaF";
            this.btnModCitaF.Size = new System.Drawing.Size(228, 84);
            this.btnModCitaF.TabIndex = 3;
            this.btnModCitaF.Text = "Modificar cita";
            this.btnModCitaF.UseVisualStyleBackColor = true;
            this.btnModCitaF.Click += new System.EventHandler(this.btnModCitaF_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.btnModCitaF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoIngrPac);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Menu de selecion - Recepcionista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoIngrPac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModCitaF;
    }
}