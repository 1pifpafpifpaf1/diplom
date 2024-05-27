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
    public partial class Админ_удаление_сотр : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Админ_удаление_сотр()
        {
            InitializeComponent();
        }

        private void Админ_удаление_сотр_Load(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            string name = logtext.Text;
            DB.OpenConnection();
            string commandStr = $"SELECT id_sotr FROM staff WHERE fio_sotr = ('{name}')";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt <= 0)
            {
                MessageBox.Show($"Сотрудника не существует");
            }
            else if (countt > 0)
            {
                string eq = $"DELETE FROM staff WHERE (fio_sotr) = ('{name}')";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show($"Сотрудник удален");
            }
            DB.CloseConnection();
            this.Hide();
        }
    }
}
