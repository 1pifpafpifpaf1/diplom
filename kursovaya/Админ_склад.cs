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
    public partial class Админ_склад : MetroFramework.Forms.MetroForm
    {
        public Админ_склад()
        {
            InitializeComponent();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
        }

        DataBase DB = new DataBase();
        public class Equipment
        {
            public int Id_sklad { get; set; }
            public string Address_sklad { get; set; }
        }
        private void FillDataGridView()
        {
            DB.OpenConnection();

            using (MySqlCommand command = new MySqlCommand("SELECT id_sklad, address_sklad FROM sklad", DB.getConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<Equipment> equipmentList = new List<Equipment>();

                    while (reader.Read())
                    {
                        Equipment equipment = new Equipment
                        {
                            Id_sklad = reader.GetInt32(0),
                            Address_sklad = reader.GetString(1)
                        };

                        equipmentList.Add(equipment);
                    }

                    dataGridView1.DataSource = equipmentList;
                }
            }
            dataGridView1.Columns["Address_sklad"].ReadOnly = false;
            dataGridView1.Columns["Id_sklad"].ReadOnly = true;
            DB.CloseConnection();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            Equipment equipment = (Equipment)dgv.Rows[e.RowIndex].DataBoundItem;

            equipment.Address_sklad = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            // Update the equipment name in the database
            DB.OpenConnection();
            using (MySqlCommand command = new MySqlCommand("UPDATE sklad SET address_sklad = @address_sklad WHERE id_sklad = @id_sklad", DB.getConnection()))
            {
                command.Parameters.AddWithValue("@id_sklad", equipment.Id_sklad);
                command.Parameters.AddWithValue("@address_sklad", equipment.Address_sklad);

                command.ExecuteNonQuery();
            }
            DB.CloseConnection();

        }

        private void Админ_склад_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Админ_склад_добавить sm = new Админ_склад_добавить();
            sm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Админ_склад_удалить sm = new Админ_склад_удалить();
            sm.ShowDialog();
        }
    }
}
