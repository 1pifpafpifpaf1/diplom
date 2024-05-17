using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Админ_сотрудники : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public class Staff
        {
            public int Id_sotr { get; set; }
            public string Fio_sotr { get; set; }
            public string Phone_sotr { get; set; }
            public int Rang_sotr { get; set; }
        }
        private void FillDataGridView()
        {
            DB.OpenConnection();

            using (MySqlCommand command = new MySqlCommand("SELECT id_sotr, fio_sotr, phone_sotr, rang_sotr FROM staff", DB.getConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Staff> staffList = new List<Staff>();

                    while (reader.Read())
                    {
                        Staff staff = new Staff
                        {
                            Id_sotr = reader.GetInt32(0),
                            Fio_sotr = reader.GetString(1),
                            Phone_sotr = reader.GetString(2),
                            Rang_sotr = reader.GetInt32(3)
                        };

                        staffList.Add(staff);
                    }

                    dataGridView1.DataSource = staffList;
                }
            }
            dataGridView1.Columns["Id_sotr"].ReadOnly = true;
            dataGridView1.Columns["Fio_sotr"].ReadOnly = false;
            dataGridView1.Columns["Phone_sotr"].ReadOnly = false;
            dataGridView1.Columns["Rang_sotr"].ReadOnly = false;
            DB.CloseConnection();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Staff staff = (Staff)dgv.Rows[e.RowIndex].DataBoundItem;

            // Get the edited column index
            int columnIndex = e.ColumnIndex;

            switch (columnIndex)
            {
                case 1: // Fio_sotr
                    staff.Fio_sotr = dgv.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    break;
                case 2: // Phone_sotr
                    staff.Phone_sotr = dgv.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();
                    break;
                case 3: // Rang_sotr
                    staff.Rang_sotr = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[columnIndex].Value);
                    break;
            }

            // Update the equipment name in the database
            DB.OpenConnection();
            using (MySqlCommand command = new MySqlCommand("UPDATE staff SET fio_sotr = @fio_sotr, phone_sotr = @phone_sotr, rang_sotr = @rang_sotr WHERE id_sotr = @id_sotr", DB.getConnection()))
            {
                command.Parameters.AddWithValue("@id_sotr", staff.Id_sotr);
                command.Parameters.AddWithValue("@fio_sotr", staff.Fio_sotr);
                command.Parameters.AddWithValue("@phone_sotr", staff.Phone_sotr);
                command.Parameters.AddWithValue("@rang_sotr", staff.Rang_sotr);

                command.ExecuteNonQuery();
            }
            DB.CloseConnection();

        }
        public Админ_сотрудники()
        {
            InitializeComponent();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
        }

        private void Админ_сотрудники_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Админ_удаление_сотр sm = new Админ_удаление_сотр();
            sm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Админ_регистрация sm = new Админ_регистрация();
            sm.ShowDialog();
        }
    }
}
