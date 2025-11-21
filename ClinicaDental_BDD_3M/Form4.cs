using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicaDental_BDD_3M
{
    public partial class Form4 : Form
    {
        string conexionSql = "server=AlexTUF;database=clinicadental_3m_equi3;port=3306;Uid=Carlos;pwd=SyecMed&c1000";
        public Form4()
        {
            InitializeComponent();
            LlenarComboBoxEsp();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarOdonto(string nombre,string apellP, string apellM, string genero, string cedula, string especialidad)
        {
            string InsertoDeOdontologo = "INSERT INTO Odontologos(nombre, apellido_paterno, apellido_materno, sexo, cedula, id_especialidad) VALUES(@Nombre, @Apellido_paterno, @Apellido_materno, @Sexo, @Cedula, @Id_especialidad)";

            using (MySqlConnection cnc = new MySqlConnection(conexionSql))
            {
                cnc.Open();

                using (MySqlCommand cmd = new MySqlCommand(InsertoDeOdontologo, cnc))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido_paterno", apellP);
                    cmd.Parameters.AddWithValue("@Apellido_materno", apellM);
                    cmd.Parameters.AddWithValue("@Sexo", genero);
                    cmd.Parameters.AddWithValue("@Cedula", cedula);
                    cmd.Parameters.AddWithValue("@Id_especialidad", especialidad);
                    cmd.ExecuteNonQuery();
                }
                cnc.Close();
            }
        }

        private void LlenarComboBoxEsp()
        {
            string ConsultaParaCMB = "SELECT Id_especialidad, Nombre FROM Especialidad";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionSql))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(ConsultaParaCMB, conn);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd); //no se para que sirve el adapter, maybe y para adaptar jeje. Convierte en la funcion que le queremos aplicar
                    DataTable dataT = new DataTable();

                    adap.Fill(dataT);

                    cmbEspecialidad.DataSource = dataT;
                    cmbEspecialidad.DisplayMember = "Nombre";
                    cmbEspecialidad.ValueMember = "Id_especialidad";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtNameOdo.Text;
            string SurP = txtSurPOdo.Text;
            string SurM = txtSurOdo.Text;
            string gen = "";
            if (rdHOM.Checked)
            {
                gen = "Hombre";
            }
            if (rdMUJ.Checked)
            {
                gen = "Mujer";
            }

            string ceduPro = txtCedulaPro.Text;

            if (ceduPro.Length > 8 || ceduPro.Length < 1)
            {
                MessageBox.Show("Ingresa una cedula profesional adecuada", "Cedula incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedulaPro.Clear();
                txtCedulaPro.Focus();
                return;
            }

            string id_Especialidad = cmbEspecialidad.SelectedValue.ToString();
            string Especialidad = cmbEspecialidad.Text;

            string datos = $"Nombre del oodontologo:{name} {SurP} {SurM}\n" +
                $"Sexo: {gen}\n"+
                $"Cedula Profesional {ceduPro}\n" +
                $"Especialidad: {Especialidad}\n";

            DialogResult = MessageBox.Show("Subir datos?\n" + datos, "Registro de odontologos", MessageBoxButtons.YesNoCancel);

            if (DialogResult == DialogResult.Yes)
            {
                RegistrarOdonto(name, SurP, SurM, gen, ceduPro, id_Especialidad);
            } 
            else if (DialogResult == DialogResult.No)
            {
                return;
            } 
            else if (DialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
