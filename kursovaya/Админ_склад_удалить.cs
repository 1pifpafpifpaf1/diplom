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
    public partial class Админ_склад_удалить : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Админ_склад_удалить()
        {
            InitializeComponent();
        }

        private void Админ_склад_удалить_Load(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            int id = Convert.ToInt32(logtext.Text);
            DB.OpenConnection();
            string commandStr = $"SELECT id_sklad FROM sklad WHERE id_sklad = ('{id}')";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt <= 0)
            {
                MessageBox.Show($"Склада не существует");
            }
            else if (countt > 0)
            {
                string eq = $"DELETE FROM sklad WHERE (id_sklad) = ('{id}')";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show($"Склад удален");
            }
            DB.CloseConnection();
        }
    }
}
