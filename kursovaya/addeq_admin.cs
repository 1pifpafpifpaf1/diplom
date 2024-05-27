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
    public partial class addeq_admin : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public addeq_admin()
        {
            InitializeComponent();
        }

        private void addeq_admin_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            string name = logtext.Text;
            DB.OpenConnection();
            string commandStr = $"SELECT id_equipment FROM equipment WHERE eq_name = (@name)";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            comm.Parameters.AddWithValue("@name", name);
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt > 0)
            {
                MessageBox.Show("Оборудование уже существует");
            }
            else if (countt == 0)
            {
                string eq = "INSERT INTO equipment (eq_name) VALUES (@name)";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                MessageBox.Show("Оборудование добавлено");
            }
            this.Hide();
        }
    }
}
