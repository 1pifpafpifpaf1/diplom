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
    public partial class Админ_оборудование : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public class Equipment
        {
            public int Id_equipment { get; set; }
            public string Eq_name { get; set; }
        }
        private void FillDataGridView()
        {
            DB.OpenConnection();

            using (MySqlCommand command = new MySqlCommand("SELECT id_equipment, eq_name FROM equipment", DB.getConnection()))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<Equipment> equipmentList = new List<Equipment>();

                        while (reader.Read())
                        {
                            Equipment equipment = new Equipment
                            {
                                Id_equipment = reader.GetInt32(0),
                                Eq_name = reader.GetString(1)
                            };

                            equipmentList.Add(equipment);
                        }

                        dataGridView1.DataSource = equipmentList;
                    }
                }
            dataGridView1.Columns["Eq_name"].ReadOnly = false;
            dataGridView1.Columns["Id_equipment"].ReadOnly = true;
            DB.CloseConnection();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Equipment equipment = (Equipment)dgv.Rows[e.RowIndex].DataBoundItem;

            equipment.Eq_name = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            // Update the equipment name in the database
            DB.OpenConnection();
            using (MySqlCommand command = new MySqlCommand("UPDATE equipment SET eq_name = @eq_name WHERE id_equipment = @id_equipment", DB.getConnection()))
                {
                    command.Parameters.AddWithValue("@id_equipment", equipment.Id_equipment);
                    command.Parameters.AddWithValue("@eq_name", equipment.Eq_name);

                    command.ExecuteNonQuery();
                }
            DB.CloseConnection();

        }
        public Админ_оборудование()
        {
            InitializeComponent();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
        }

        private void Админ_оборудование_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addeq_admin sm = new addeq_admin();
            sm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            /*Удаление_Админ sm = new Удаление_Админ();
            sm.ShowDialog();*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить данное оборудование?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id_equipment"].Value);

                    DB.OpenConnection();
                    using (MySqlCommand command = new MySqlCommand("DELETE FROM equipment WHERE id_equipment = @id_equipment", DB.getConnection()))
                    {
                        command.Parameters.AddWithValue("@id_equipment", id);
                        command.ExecuteNonQuery();
                    }
                    FillDataGridView();
                    dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
                    DB.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }
    }
}
