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
    public partial class Form6 : Form
    {
        string Conex = "server=localhost;database=clinicadental_3m_equi3;port=3306;Uid=root;pwd=SyecMed&c1000";

        public Form6()
        {
            InitializeComponent();
            LlenarComboPaciente();
            LlenarComboOdontologo();
            LlenarComboTratamiento();

            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
            cmbtratamiento.SelectedIndexChanged += Cmbtratamiento_SelectedIndexChanged;
            cmbtratamiento.SelectedIndexChanged += cmbTratamientos_SelectedIndexChanged;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start.Date;
            if (cmbodontologo.SelectedValue != null)
            {
                string idOdo = cmbodontologo.SelectedValue.ToString();
                LlenandoDataGrid(idOdo, fechaSeleccionada);
            }
        }

        private void LlenarComboPaciente()
        {
            string ConsultaPac = "SELECT Id_paciente, Nombre FROM Paciente";

            try
            {
                using (MySqlConnection con = new MySqlConnection(Conex))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(ConsultaPac, con);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataTable dataPac = new DataTable();

                    adap.Fill(dataPac);

                    cmbPaciente.DataSource = dataPac;
                    cmbPaciente.DisplayMember = "Nombre";
                    cmbPaciente.ValueMember = "Id_paciente";
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void LlenarComboOdontologo()
        {
            string Query = "SELECT Id_odo, Nombre FROM Odontologos";
            try
            {
                using (MySqlConnection con = new MySqlConnection(Conex))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataOdontologo = new DataTable();

                    adapter.Fill(dataOdontologo);

                    cmbodontologo.DataSource = dataOdontologo;
                    cmbodontologo.DisplayMember = "Nombre";
                    cmbodontologo.ValueMember = "Id_odo";

                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            } 
        }

        private void LlenarComboTratamiento()
        {
            string Query = "SELECT Id_trata, Nombre, Costo FROM Tratamientos";
            try
            {
                using (MySqlConnection con = new MySqlConnection(Conex))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataTable dataT = new DataTable();

                    adap.Fill(dataT);

                    cmbtratamiento.DataSource = dataT;
                    cmbtratamiento.DisplayMember = "Nombre";
                    cmbtratamiento.ValueMember = "Id_trata";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message );
            }
        }

        private void Cmbtratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtratamiento.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cmbtratamiento.SelectedItem;
                decimal costo = Convert.ToDecimal(row["costo"]);
                lblCosto.Text = $"{costo}"; // Formato: $2,000.00
            }
        }


        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            string paciente, odontologo, tratamiento, costo, hora, estado;
            DateTime fecha;

            estado = "Pendiente";

            paciente = cmbPaciente.Text;
            string id_paciente = cmbPaciente.SelectedValue.ToString();

            odontologo = cmbodontologo.Text;
            string id_odontologo = cmbodontologo.SelectedValue.ToString();

            tratamiento = cmbtratamiento.Text;
            string id_tratamiento = cmbtratamiento.SelectedValue.ToString();

            costo = lblCosto.Text;
            decimal CostoDeCita = decimal.Parse(costo);

            fecha = monthCalendar1.SelectionStart.Date;
            hora = mskTxtHora.Text;
            TimeSpan Hora = TimeSpan.Parse(hora);
            string tiempo = lblTiempo.Text;


            string datos = $"El paciente: {paciente}\n" +
                $"Sera atendido por: {odontologo}\n" +
                $"Con el tratamiento de: {tratamiento}\n" +
                $"Con un costo de: {costo}\n" +
                $"El {fecha} a las {hora}";

            DialogResult = MessageBox.Show("Desea subir los datos?\n\n" + datos, "Registro de citas", MessageBoxButtons.YesNoCancel);

            if (DialogResult == DialogResult.Yes)
            {
                IngresarCita(id_paciente, id_odontologo, id_tratamiento, fecha, Hora, estado, CostoDeCita, tiempo);
            } 
            if (DialogResult == DialogResult.No)
            {
                return;
            } 
        }

        private void IngresarCita(string id_pacien, string id_odonto, string id_tratamin, DateTime fechac, TimeSpan hora, string estado, decimal costo, string tiempo)
        {
            string Insert = "INSERT INTO Cita (id_paciente, id_odo, id_trata, fecha_cita, hora, estado, costo, tiempoEst, estadoPagado) VALUES (@id_paciente, @id_odo, @id_trata, @fecha_cita, @hora, @estado, @costo, @tiempoEst, 'SIN PAGAR')";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(Conex))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(Insert, cnc))
                    {
                        cmd.Parameters.AddWithValue("@id_paciente", id_pacien);
                        cmd.Parameters.AddWithValue("@id_odo", id_odonto);
                        cmd.Parameters.AddWithValue("@id_trata", id_tratamin);
                        cmd.Parameters.AddWithValue("@fecha_cita", fechac);
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@costo", costo);
                        cmd.Parameters.AddWithValue("@tiempoEst", tiempo);
                        cmd.ExecuteNonQuery();
                    }
                    cnc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void LlenandoDataGrid(string idodo, DateTime fech)
        {

            try
            {
                string Query = "SELECT * FROM cita WHERE id_odo = @Idodo AND DATE(fecha_cita) = @Fecha AND estado = 'pendiente' ORDER BY fecha_cita";

                using (MySqlConnection cnc = new MySqlConnection(Conex))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, cnc);

                    cmd.Parameters.AddWithValue("@Idodo", idodo);
                    cmd.Parameters.AddWithValue("@Fecha", fech);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dtGridDatosCitasAnt.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay citas anteriores para este odontologo", "Sin citas precias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void CargarTiempoEstimado(string idTratamiento)
        {
            try
            {
                string query = "SELECT tiempoEstimado FROM tratamientos WHERE id_trata = @Id_tratamiento";

                using (MySqlConnection cnc = new MySqlConnection(Conex))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@Id_tratamiento", idTratamiento);

                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            lblTiempo.Text = resultado.ToString();
                        }
                        else
                        {
                            lblTiempo.Text = "No disponible";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTratamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtratamiento.SelectedValue != null && cmbtratamiento.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {
                string idTratamiento = cmbtratamiento.SelectedValue.ToString();
                CargarTiempoEstimado(idTratamiento);
            }
        }
    }
}
