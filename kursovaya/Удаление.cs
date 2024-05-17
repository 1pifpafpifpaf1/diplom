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
        void GetComboBoxList()
        {
            //Формирование списка статусов
            DataTable list_eq_table = new DataTable();
            MySqlCommand list_stud_command = new MySqlCommand();
            //Открываем соединение
            DB.OpenConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_eq_table.Columns.Add(new DataColumn("id_eq_sklad", System.Type.GetType("System.Int32")));
            list_eq_table.Columns.Add(new DataColumn("id_equipment", System.Type.GetType("System.Int32")));
            //Настройка видимости полей комбобокса
            eqbox.DataSource = list_eq_table;
            eqbox.DisplayMember = "id_eq_sklad";
            eqbox.ValueMember = "id_equipment"; 
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_users = $"SELECT id_eq_sklad, id_equipment FROM eq_sklad WHERE id_sklad ={Auth.auth_role}";
            list_stud_command.CommandText = sql_list_users;
            list_stud_command.Connection = DB.getConnection();
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_eq_reader;
            try
            {
                //Инициализируем ридер
                list_eq_reader = list_stud_command.ExecuteReader();
                while (list_eq_reader.Read())
                {
                    DataRow rowToAdd = list_eq_table.NewRow();
                    rowToAdd["id_eq_sklad"] = Convert.ToInt32(list_eq_reader[0]);
                    rowToAdd["id_equipment"] = Convert.ToInt32(list_eq_reader[1]);
                    list_eq_table.Rows.Add(rowToAdd);
                }
                list_eq_reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка ЦП \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                DB.CloseConnection();
            }
        }
        public Удаление()
        {
            InitializeComponent();
        }

        private void Удаление_Load(object sender, EventArgs e)
        {
            GetComboBoxList();
        }

        private void deletebutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            DB.OpenConnection();
            int id_eq = Convert.ToInt32(eqbox.SelectedValue);
            int count = Convert.ToInt32(boxcount.SelectedItem);
            string commandStr = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt >= count)
            {
                countt -= count;
                if (countt > 0)
                {
                     
                     // запрос обновления данных
                     string update = $"UPDATE eq_sklad SET eq_count = '{countt}' WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
                     // объект для выполнения SQL-запроса
                     MySqlCommand command = new MySqlCommand(update, DB.getConnection());
                     // выполняем запрос    
                     command.ExecuteNonQuery();
/*                    DateTime data_des = DateTime.Now;
                    var data = data_des.ToString("yyyy-MM-dd H:mm:ss"); 
                    string query = $"INSERT INTO eq_destroyed (id_equipment, id_sotr, data_des) VALUES ('{id_eq}', '{Auth.auth_id}', '{data}')";
                    // объект для выполнения SQL-запроса
                    MySqlCommand command1 = new MySqlCommand(query, DB.getConnection());
                    // выполняем запрос
                    command1.ExecuteNonQuery();*/
                    MessageBox.Show("Удалено");

                }
                else if (countt == 0)
                {
                    string delete = $"DELETE FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
                    // объект для выполнения SQL-запроса
                    MySqlCommand command = new MySqlCommand(delete, DB.getConnection());
                    // выполняем запрос    
                    command.ExecuteNonQuery();
                }
                //catch(Exception ex)
                //{
                //    MessageBox.Show("Ошибка" + ex);
                //}
            }
            DB.CloseConnection();
        }
    }
}
