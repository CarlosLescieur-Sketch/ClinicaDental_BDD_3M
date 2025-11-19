using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDental_BDD_3M
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNuevoIngrPac_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificacionDePacientes mod = new ModificacionDePacientes();
            this.Hide();
            mod.ShowDialog();
        }

        private void btnModCitaF_Click(object sender, EventArgs e)
        {
            ModiCita modiCita = new ModiCita();
            this.Hide();
            modiCita.ShowDialog();
        }
    }
}
