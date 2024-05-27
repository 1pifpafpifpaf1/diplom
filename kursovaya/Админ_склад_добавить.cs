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
    public partial class Админ_склад_добавить : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        public Админ_склад_добавить()
        {
            InitializeComponent();
        }

        private void Админ_склад_добавить_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            string name = logtext.Text;
            DB.OpenConnection();
            string commandStr = $"SELECT id_sklad FROM sklad WHERE address_sklad = ('{name}')";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt > 0)
            {
                MessageBox.Show($"Склад уже существует");
            }
            else if (countt == 0)
            {
                string eq = $"INSERT INTO sklad (address_sklad) VALUES ('{name}')";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show($"Склад добавлен");
            }
            this.Hide();
        }
    }
}
