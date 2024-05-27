using MySql.Data.MySqlClient;
using Nevron.Nov;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovaya
{
    public partial class Удаление : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

        public Удаление()
        {
            InitializeComponent();
            LoadAutoCompleteData();
        }

        private void LoadAutoCompleteData()
        {
            try
            {
                DB.OpenConnection();
                string query = "SELECT eq_name FROM equipment";
                MySqlCommand command = new MySqlCommand(query, DB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    autoCompleteCollection.Add(reader.GetString("eq_name"));
                }

                reader.Close();
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных для автозаполнения: " + ex.Message);
            }

            logtext.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            logtext.AutoCompleteSource = AutoCompleteSource.CustomSource;
            logtext.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void Удаление_Load(object sender, EventArgs e)
        {
        }

        private void deletebutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            DB.OpenConnection();
            string eq_name = logtext.Text;

            string commandStr1 = $"SELECT id_equipment FROM equipment WHERE eq_name = '{eq_name}'";
            MySqlCommand comm1 = new MySqlCommand(commandStr1, DB.getConnection());
            int id = Convert.ToInt32(comm1.ExecuteScalar());

            int count = Convert.ToInt32(logtext2.Text);

            string commandStr = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = '{id}' AND id_sklad = '{Auth.auth_role}'";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt > 0) 
            {
                if (countt >= count)
                {
                    countt -= count;
                    if (countt > 0)
                    {

                        // запрос обновления данных
                        string update = $"UPDATE eq_sklad SET eq_count = '{countt}' WHERE id_equipment = '{id}' AND id_sklad = '{Auth.auth_role}'";
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(update, DB.getConnection());
                        // выполняем запрос    
                        command.ExecuteNonQuery();
                        MessageBox.Show("Удалено");

                    }
                    else if (countt == 0)
                    {
                        string delete = $"DELETE FROM eq_sklad WHERE id_equipment = '{id}' AND id_sklad = '{Auth.auth_role}'";
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(delete, DB.getConnection());
                        // выполняем запрос    
                        command.ExecuteNonQuery();
                        MessageBox.Show("Удалено");
                    }
                }
                else if (countt < count)
                {
                    MessageBox.Show("На складе недостаточно оборудования");
                }
            }
            else if (countt == 0) 
            {
                MessageBox.Show("Оборудования нет на складе");
            }

            DB.CloseConnection();
            this.Hide();
        }
    }
}
