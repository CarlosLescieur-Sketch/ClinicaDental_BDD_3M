using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicaDental_BDD_3M
{
    public partial class ModificacionDePacientes : Form
    {
        string con = "server=localhost;database=clinicadental_3m_equi3;port=3306;Uid=root;pwd=SyecMed&c1000";
        public ModificacionDePacientes()
        {
            InitializeComponent();
            LlenarCmbPac();
            cmbPac.SelectedIndexChanged += Cmbpac_SelectedChanged;
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            string idpac = cmbPac.SelectedValue.ToString();

            string nombre = txtNameP.Text;
            string gene = "";
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
            string fotosgra = chkListArchivosAdj.GetItemChecked(1) ? "Y" : "N";
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
                $"Telefono: {telefono}\n" +
                $"Email: {email}";
            // $"Odontologo que lo atendera: {odonto}";

            DialogResult result = (MessageBox.Show("Subir datos?\n\n" + datosPac, "Registro de Pacientes", MessageBoxButtons.YesNoCancel));
            if (result == DialogResult.Yes)
            {
                ModificarPacientes(idpac, nombre, surP, surM, BD, gene, radiograf, fotosgra, recet, alergia, ante, enfer, telefono, email);
            }
        }

        private void ActualizarConCMB(string idpac)
        {
            try
            {
                string query = "SELECT id_paciente, nombre, ape_pat, ape_mat, fecha_nacimiento, alergias, antecedentes, enfermedades FROM paciente WHERE id_paciente = @Id_paciente";
                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@Id_paciente", idpac);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNameP.Text = reader["nombre"].ToString();
                                txtSurP.Text = reader["ape_pat"].ToString();
                                txtSurM.Text = reader["ape_mat"].ToString();

                                if (reader["fecha_nacimiento"] != DBNull.Value)
                                {
                                    txtFBirth.Text = Convert.ToDateTime(reader["fecha_nacimiento"]).ToString("dd/MM/yyyy");
                                }
                                else
                                {
                                    txtFBirth.Text = "";
                                }

                                txtAlerP.Text = reader["alergias"] != DBNull.Value ? reader["alergias"].ToString() : "";
                                txtAnte.Text = reader["antecedentes"] != DBNull.Value ? reader["antecedentes"].ToString() : "";
                                txtIll.Text = reader["enfermedades"] != DBNull.Value ? reader["enfermedades"].ToString() : "";
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el paciente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void Cmbpac_SelectedChanged(object sender, EventArgs e)
        {
            if (cmbPac.SelectedValue != null && cmbPac.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                string idpapc = cmbPac.SelectedValue.ToString();
                ActualizarConCMB(idpapc);
            }
        }

        private void LlenarCmbPac()
        {
            string query = "SELECT id_paciente, nombre FROM paciente";

            try
            {
                using(MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cmbPac.DataSource = dataTable;
                    cmbPac.DisplayMember = "nombre";
                    cmbPac.ValueMember = "id_paciente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        private void ModificarPacientes(string idpac, string nombre, string apell_pa, string apell_ma, DateTime BD, string genero, string radios, string fotos, string rece, string alergias, string antecedentes, string enferme, string telefono, string email)
        {
            string query = "UPDATE paciente SET nombre = @Nombre, ape_pat = @Ape_pat, ape_mat = @Ape_mat, fecha_nacimiento = @Fecha_nacimiento, sexo = @Sexo, radiografias = @Radiografias, fotografias = @Fotografias, recetas = @Recetas, alergias = @Alergias, antecedentes = @Antecedentes, enfermedades = @Enfermedades, contacto = @Contacto, email = @Email WHERE id_paciente = @Id_paciente";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@Id_paciente", idpac);
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
                    cnc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
