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
    public partial class Удаление_Админ : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();

        public Удаление_Админ()
        {
            InitializeComponent();
        }

        private void Удаление_Админ_Load(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            string name = logtext.Text;
            DB.OpenConnection();
            string commandStr = $"SELECT id_equipment FROM equipment WHERE eq_name = ('{name}')";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt <= 0)
            {
                MessageBox.Show($"Оборудование не существует");
            }
            else if (countt > 0)
            {
                string eq = $"DELETE FROM equipment WHERE (eq_name) = ('{name}')";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show($"Оборудование удаление");
            }
            DB.CloseConnection();
            this.Hide();
        }

        private void logtext_Click(object sender, EventArgs e)
        {

        }
    }
}
