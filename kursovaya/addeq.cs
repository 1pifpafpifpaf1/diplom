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

namespace kursovaya
{
    public partial class addeq : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();

 
        public addeq()
        {
            InitializeComponent();

        }

        private void addeq_Load(object sender, EventArgs e)
        {
            Getcombo.GetComboBox(eqbox, "id_equipment", "eq_name", "equipment");
        }

        private void addbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            DB.OpenConnection();
            int id_eq = Convert.ToInt32(eqbox.SelectedValue);
            int count = Convert.ToInt32(boxcount.SelectedItem);
            string commandStr = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());

            if (countt > 0)
            {

                countt += count;
                // запрос обновления данных
                string update = $"UPDATE eq_sklad SET eq_count = '{countt}' WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(update, DB.getConnection());
                // выполняем запрос
                command.ExecuteNonQuery();
            }
            else if (countt == 0)
            //catch
            {
                string eq_sklad = $"INSERT INTO eq_sklad (id_equipment, id_sklad, eq_count) VALUES ('{id_eq}', '{Auth.auth_role}','{count}')";
                MySqlCommand command = new MySqlCommand(eq_sklad, DB.getConnection());
                command.ExecuteNonQuery();
            }

            DB.CloseConnection();
        }
    }
}
