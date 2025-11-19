using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ClinicaDental_BDD_3M
{
    public partial class Form3 : Form
    {
        string conexionSql = "server=localhost;database=clinicadental_3m_equi3;port=3306;Uid=root;pwd=SyecMed&c1000";
        public Form3()
        {
            InitializeComponent();
            //LlenarComboBox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNameP.Text;
            string gene="";
            string surP = txtSurP.Text;
            string surM = txtSurM.Text;
            DateTime BD = DateTime.Parse(txtFBirth.Text);
            if (rdMan.Checked)
            {
                gene = "Hombre";
            }
            if (rdWoman.Checked)
            {
                gene = "Mujer";
            }
            if (!rdMan.Checked && !rdWoman.Checked)
            {
                MessageBox.Show("Por favor, selecciona un sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string radiograf = chkListArchivosAdj.GetItemChecked(0) ? "Y" : "N";
            string fotosgra = chkListArchivosAdj.GetItemChecked (1) ? "Y" : "N";
            string recet = chkListArchivosAdj.GetItemChecked(2) ? "Y" : "N";

            string alergia = txtAlerP.Text;
            string ante = txtAnte.Text;
            string enfer = txtIll.Text;

            string telefono = txtNumCel.Text;
            string email = txtEmail.Text;

            // string odonto = cboxOdontologo.Text;

            string datosPac = $"Nombre del paciente{nombre} {surP} {surM}\n" +
                $"Fecha de nacimiento: {BD}\n" +
                $"Sexo: {gene}\n" +
                $"Radiografias: {radiograf}\n" +
                $"Fotografias: {fotosgra}\n" +
                $"Receta: {recet}\n" +
                $"Alergia/s: {alergia}\n" +
                $"Antecedentes medicos: {ante}\n" +
                $"Enfermedades: {enfer}\n" +
                $"$Telefono: {telefono}\n" +
                $"Email: {email}";
                // $"Odontologo que lo atendera: {odonto}";

            DialogResult result = (MessageBox.Show("Subir datos?\n\n" + datosPac, "Registro de Pacientes", MessageBoxButtons.YesNoCancel));
            if(result == DialogResult.Yes)
            {
                InsertarPacientes(nombre, surP, surM, BD, gene, radiograf, fotosgra, recet, alergia, ante, enfer, telefono, email);
            }

            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
            this.Show();
        }


        private void InsertarPacientes(string nombre, string apell_pa, string apell_ma, DateTime BD ,string genero, string radios, string fotos, string rece, string alergias, string antecedentes, string enferme, string telefono, string email)
        {
            string InsertoDePac = "INSERT INTO Paciente(nombre, ape_pat, ape_mat, fecha_nacimiento, sexo, radiografias, fotografias, recetas, alergias, antecedentes, enfermedades, contacto, email)" +
                " VALUES(@Nombre, @Ape_pat, @Ape_mat, @Fecha_nacimiento, @Sexo, @Radiografias, @Fotografias, @Recetas, @Alergias, @Antecedentes, @Enfermedades, @Contacto, @Email)";

            try
            {
                using (MySqlConnection cncPac = new MySqlConnection(conexionSql))
                {
                    cncPac.Open();
                    using (MySqlCommand cmd = new MySqlCommand(InsertoDePac, cncPac))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Ape_pat", apell_pa);
                        cmd.Parameters.AddWithValue("@Ape_mat", apell_ma);
                        cmd.Parameters.AddWithValue("@Fecha_nacimiento", BD);
                        cmd.Parameters.AddWithValue("@Sexo", genero);
                        cmd.Parameters.AddWithValue("@Radiografias", radios);
                        cmd.Parameters.AddWithValue("@Fotografias", fotos);
                        cmd.Parameters.AddWithValue("@Recetas", rece);
                        cmd.Parameters.AddWithValue("@Alergias", alergias);
                        cmd.Parameters.AddWithValue("@Antecedentes", antecedentes);
                        cmd.Parameters.AddWithValue("@Enfermedades", enferme);
                        cmd.Parameters.AddWithValue("@Contacto", telefono);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                    cncPac.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}