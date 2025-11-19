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
    public partial class Form5 : Form
    {
        string ConexionMySQL = "server=localhost;database=clinicadental_3m_equi3;port=3306;uid=root;pwd=SyecMed&c1000";
        public Form5()
        {
            InitializeComponent();
            LlenarComboBoxEspecialidad();
        }

        private void RegistroDeTratamiento(string especialidad, string nombre, string descripcion, decimal costo, string tiempo)
        {
            string InsertoDeTratamiento = "INSERT INTO Tratamientos(id_especialidad, nombre, descripcion, costo, tiempoEstimado) VALUES(@Id_especialidad, @Nombre, @Descripcion, @Costo, @TiempoEstimado)";

            using (MySqlConnection cn = new MySqlConnection(ConexionMySQL))
            {
                cn.Open();

                using (MySqlCommand cmd = new MySqlCommand(InsertoDeTratamiento, cn))
                {
                    cmd.Parameters.AddWithValue("@Id_especialidad", especialidad);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@Costo", costo);
                    cmd.Parameters.AddWithValue("@TiempoEstimado", tiempo);
                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }
        }

        private void btnRegTrataNew_Click(object sender, EventArgs e)
        {
            string id_especialidad = cmbEspecialidad.SelectedValue.ToString();
            string name_especialidad = cmbEspecialidad.Text;
            
            string nameTrataNew = txtNombreTratNew.Text;
            string desc = txtDescripcionTrataNew.Text;
            decimal costo = int.Parse(txtCostoTrataNew.Text);

            string tiempo = txtTiempo.Text;

            string datos = $"Deseas subir los siguientes datos?\n\n" +
                $"Especialidad capaz de hacer el tratamiento: {name_especialidad}\n" +
                $"Nombre de el tratamiento: {nameTrataNew}\n" +
                $"Descripcion del tratamiento {desc} \n" +
                $"Costo: {costo} \n" +
                $"Tiempo estimado: {tiempo}";

            DialogResult = MessageBox.Show(datos, "Registro de nuevos datos", MessageBoxButtons.YesNoCancel);

            if(DialogResult == DialogResult.Yes)
            {
                RegistroDeTratamiento(id_especialidad, nameTrataNew, desc, costo, tiempo);
            }
            else if(DialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }

        private void LlenarComboBoxEspecialidad()
        {
            string ConsultaCMBEsp = "SELECT Id_especialidad, Nombre FROM Especialidad";
            try
            {
            using (MySqlConnection cnc = new MySqlConnection(ConexionMySQL))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(ConsultaCMBEsp, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cmbEspecialidad.DataSource = dataTable;
                    cmbEspecialidad.DisplayMember = "Nombre";
                    cmbEspecialidad.ValueMember = "Id_especialidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
