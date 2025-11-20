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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace ClinicaDental_BDD_3M
{
    public partial class MedMenu : Form
    {
        string con = "server=localhost;database=clinicadental_3m_equi3;port=3306;Uid=root;pwd=SyecMed&c1000";

        public MedMenu()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            LlenarCmbOdo();

            cmbMed.SelectedIndexChanged += CmbMed_SelectedIndexChanged;
            cmbpaciAAtender.SelectedIndexChanged += CmbPac_SelectedIndexChannged;
        }

        private void LlenarCmbOdo()
        {
            string query = "SELECT id_odo, nombre FROM odontologos";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    cmbMed.DataSource = dataTable;
                    cmbMed.DisplayMember = "nombre";
                    cmbMed.ValueMember = "id_odo";
                    cnc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CmbMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMed.SelectedValue != null && cmbMed.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string idOdontologo = cmbMed.SelectedValue.ToString();
                LlenarCmbPacientesPorOdontologo(idOdontologo);
            }
        }

        // Método que llena el ComboBox de pacientes según el odontólogo seleccionado
        //HAY QUE ESTUDIAR ESTO (HECHO POR IA)
        private void LlenarCmbPacientesPorOdontologo(string idOdontologo)
        {
            // Query que obtiene los pacientes que tienen citas con el odontólogo seleccionado
            // string query = @"SELECT DISTINCT p.id_paciente, p.nombre FROM paciente p INNER JOIN cita c ON p.id_paciente = c.id_paciente  WHERE c.id_odo = @id_odo ORDER BY p.nombre";

            string query = "SELECT p.id_paciente, p.nombre FROM cita c, paciente p WHERE c.id_paciente = p.id_paciente AND c.id_odo = @id_odo AND c.estado='Pendiente' ORDER BY c.fecha_cita;";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_odo", idOdontologo);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);

                    // Asume que tienes un ComboBox llamado cmbPaciente
                    cmbpaciAAtender.DataSource = dataTable;
                    cmbpaciAAtender.DisplayMember = "nombre";
                    cmbpaciAAtender.ValueMember = "id_paciente";

                    // Mensaje si no hay pacientes para ese odontólogo
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Este odontólogo no tiene pacientes asignados aún.",
                                      "Información",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }

                    cnc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void CmbPac_SelectedIndexChannged(object sender, EventArgs e)
        {
            {
                if (cmbpaciAAtender.SelectedValue != null)
                {
                    string idPac = cmbpaciAAtender.SelectedValue.ToString();
                    LlenandoDataGrid(idPac);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una cita del listado.",
                               "Advertencia",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                string idCita = filaSeleccionada.Cells["id_cita"].Value.ToString();
                string nombrePaciente = filaSeleccionada.Cells["Paciente"].Value.ToString();
                string apePaterno = filaSeleccionada.Cells["ApellidoPaterno"].Value.ToString();
                string apeMaterno = filaSeleccionada.Cells["ApellidoMaterno"].Value.ToString();
                string nombreCompleto = $"{nombrePaciente} {apePaterno} {apeMaterno}";
                string nombreOdontologo = filaSeleccionada.Cells["Odontologo"].Value.ToString();
                string fechaCita = Convert.ToDateTime(filaSeleccionada.Cells["fecha_cita"].Value).ToString("dd/MM/yyyy");
                string horaCita = filaSeleccionada.Cells["hora"].Value.ToString();
                string costo = "$" + Convert.ToDecimal(filaSeleccionada.Cells["costo"].Value).ToString("N2");

                // Obtener el tratamiento (necesitas agregarlo a tu query)
                string tratamiento = "Consulta General"; // Si no lo tienes en el query, usa un valor por defecto

                // Generar el PDF antes de modificar el estado
                GenerarReportePDF(nombreCompleto, nombreOdontologo, tratamiento, fechaCita, horaCita, costo);

                // Modificar el estado
                modEstado(idCita);

                // Recargar el grid después de modificar
                if (cmbpaciAAtender.SelectedValue != null)
                {
                    string idPac = cmbpaciAAtender.SelectedValue.ToString();
                    LlenandoDataGrid(idPac);
                }

                MessageBox.Show("Cita marcada como concluida correctamente y reporte generado.",
                               "Éxito",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la cita: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void GenerarReportePDF(string nombrePaciente, string nombreOdontologo,
                                       string tratamiento, string fechaCita,
                                       string horaCita, string costo)
        {
            try
            {
                string plantillaHtml = Properties.Resources.plantilla;

                // Reemplazar las variables en la plantilla
                string htmlFinal = plantillaHtml
                    .Replace("{{NombreDelPaciente}}", nombrePaciente)
                    .Replace("{{NombreDelOdontologo}}", nombreOdontologo)
                    .Replace("{{Tratamiento}}", tratamiento)
                    .Replace("{{FechaDeCita}}", fechaCita)
                    .Replace("{{HoraDeConsulta}}", horaCita)
                    .Replace("{{CostoDeLaCita}}", costo)
                    .Replace("{{FechaYHoraActual}}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

                // Configurar el diálogo para guardar el archivo
                SaveFileDialog guardarArchivo = new SaveFileDialog();
                guardarArchivo.Filter = "Archivo PDF|*.pdf";
                guardarArchivo.Title = "Guardar Reporte de Cita";
                guardarArchivo.FileName = $"Reporte_Cita_{nombrePaciente.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    // Crear el documento PDF
                    Document documento = new Document(PageSize.LETTER);
                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(guardarArchivo.FileName, FileMode.Create));

                    documento.Open();

                    // Convertir HTML a PDF usando XMLWorkerHelper
                    using (StringReader sr = new StringReader(htmlFinal))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, documento, sr);
                    }

                    documento.Close();

                    // Preguntar si desea abrir el archivo
                    DialogResult resultado = MessageBox.Show(
                        "El reporte se ha generado correctamente.\n¿Desea abrir el archivo?",
                        "PDF Generado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(guardarArchivo.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void modEstado(string idCita)
        {
            try
            {
                string que = "UPDATE cita SET estado = 'Concluida' WHERE id_cita = @Id_cita";

                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(que, cnc);
                    cmd.Parameters.AddWithValue("@Id_cita", idCita);  // ✅ Corregido
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        // También debes modificar LlenandoDataGrid para incluir id_cita
        private void LlenandoDataGrid(string idpac)
        {
            try
            {
                string que = @"SELECT c.id_cita,
                     p.nombre AS Paciente, 
                     p.ape_pat AS ApellidoPaterno,
                     p.ape_mat AS ApellidoMaterno,
                     o.nombre AS Odontologo, 
                     c.fecha_cita, 
                     c.hora,
                     c.costo
              FROM cita c
              JOIN odontologos o ON c.id_odo = o.id_odo
              JOIN paciente p ON c.id_paciente = p.id_paciente
              WHERE c.id_paciente = @id_paciente 
              AND c.estado = 'Pendiente'";

                using (MySqlConnection cnc = new MySqlConnection(con))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(que, cnc);
                    cmd.Parameters.AddWithValue("@id_paciente", idpac);
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    ada.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Opcional: Ocultar la columna id_cita si no quieres mostrarla
                    if (dataGridView1.Columns["id_cita"] != null)
                    {
                        dataGridView1.Columns["id_cita"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelPac_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para eliminar");
                return;
            }

            string idpac = dataGridView1.SelectedRows[0].Cells["id_cita"].Value.ToString();
            DialogResult res = MessageBox.Show("Estas COMPLETAMENTE SEGURO de querer borrar este registro de paciente?", "Confirmacion de borrado de registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                bool elim = Borrar(idpac);
                if (elim)
                {
                    MessageBox.Show("Paciente ELIMINADO", "Eliminacion de pacientes exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
        }

        private bool Borrar(string idpac)
        {
            try
            {
                string queryDel = "DELETE FROM cita WHERE id_cita = @Id_cita";

                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryDel, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id_cita", idpac);
                        int filasAfec = cmd.ExecuteNonQuery();
                        if (filasAfec == 0)
                        {
                            MessageBox.Show("No se encontro el paciente o ya fue eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}