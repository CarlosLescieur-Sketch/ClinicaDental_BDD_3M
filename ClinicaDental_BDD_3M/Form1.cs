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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pwd = txtPassw.Text;

            if(user == "recepcion" && pwd == "rpt2025")
            {
                Form2 form2 = new Form2();
                this.Hide(); // Ocultar el login
                form2.ShowDialog();
                this.Show();
                txtPassw.Text = null;
                txtUser.Text = null;
                txtPassw.Focus();
                // mandamos a form de los recepcionistas
            } 
            if (user == "medOdonto" && pwd == "pwodo1990")
            {
                this.Hide();
                MedMenu md = new MedMenu();
                md.ShowDialog();
                this.Show();
                txtPassw.Text = null;
                txtUser.Text = null;
                txtPassw.Focus();
            }

            {
                // mandamos a forms de los medicos
            } if (user == "admin2006" && pwd == "carlosjeje")
            {
                // mandmamos a form del administrador
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();
                this.Show();
                txtPassw.Text = null;
                txtUser.Text = null;
                txtPassw.Focus();
            }

            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto, vuelve a ingresar", "Jeje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
