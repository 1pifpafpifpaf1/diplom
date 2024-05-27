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
    public partial class Запросы : MetroFramework.Forms.MetroForm
    {
        public Запросы()
        {
            InitializeComponent();
        }
        DataBase DB = new DataBase();
        void GetComboBoxList()
        {
            //Формирование списка статусов
            DataTable list_eq_table = new DataTable();
            MySqlCommand list_stud_command = new MySqlCommand();
            //Открываем соединение
            DB.OpenConnection();
            //Формируем столбцы для комбобокса списка ЦП
            list_eq_table.Columns.Add(new DataColumn("id_request", System.Type.GetType("System.Int32")));
            //Настройка видимости полей комбобокса
            eqbox.DataSource = list_eq_table;
            eqbox.DisplayMember = "id_request";
            eqbox.ValueMember = "id_request";
            //Формируем строку запроса на отображение списка статусов прав пользователя
            string sql_list_users = $"SELECT id_request FROM request WHERE NOT id_sklad = {Auth.auth_role}";
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
                    rowToAdd["id_request"] = Convert.ToInt32(list_eq_reader[0]);
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
        private void reqbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            int id_req = Convert.ToInt32(eqbox.SelectedValue);
            DB.OpenConnection();
            string coun = $"SELECT eq_count FROM request WHERE id_request = {id_req}";
            MySqlCommand comm1 = new MySqlCommand(coun, DB.getConnection());
            int count = Convert.ToInt32(comm1.ExecuteScalar());
            string ideq = $"SELECT id_equipment FROM request WHERE id_request = {id_req}";
            MySqlCommand comm2 = new MySqlCommand(ideq, DB.getConnection());
            int id_eq = Convert.ToInt32(comm2.ExecuteScalar());
            string idsklad = $"SELECT id_sklad FROM request WHERE id_request = {id_req}";
            MySqlCommand comm5 = new MySqlCommand(idsklad, DB.getConnection());
            int id_sklad = Convert.ToInt32(comm5.ExecuteScalar());
            string commandStr = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {id_sklad}";
            MySqlCommand comm3 = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm3.ExecuteScalar());
            string deleq = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
            MySqlCommand comm4 = new MySqlCommand(deleq, DB.getConnection());
            int countt2 = Convert.ToInt32(comm4.ExecuteScalar());
            if (countt2 > 0)
            {
                string del = $"DELETE FROM request WHERE id_request = {id_req}";
                MySqlCommand comm = new MySqlCommand(del, DB.getConnection());
                comm.ExecuteNonQuery();
                if (countt > 0)
                {

                    countt += count;
                    // запрос обновления данных
                    string update = $"UPDATE eq_sklad SET eq_count = '{countt}' WHERE id_equipment = {id_eq} AND id_sklad = {id_sklad}";
                    // объект для выполнения SQL-запроса
                    MySqlCommand command = new MySqlCommand(update, DB.getConnection());
                    // выполняем запрос
                    command.ExecuteNonQuery();
                }
                else if (countt == 0)
                {
                    string eq_sklad = $"INSERT INTO eq_sklad (id_equipment, id_sklad, eq_count) VALUES ('{id_eq}', '{id_sklad}','{count}')";
                    MySqlCommand command = new MySqlCommand(eq_sklad, DB.getConnection());
                    command.ExecuteNonQuery();
                }
                if (countt2 >= count)
                {
                    countt2 -= count;
                    if (countt2 > 0)
                    {

                        // запрос обновления данных
                        string update = $"UPDATE eq_sklad SET eq_count = '{countt2}' WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(update, DB.getConnection());
                        // выполняем запрос    
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запрос подтвержден");
                    }
                    else if (countt2 == 0)
                    {
                        string delete = $"DELETE FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {Auth.auth_role}";
                        // объект для выполнения SQL-запроса
                        MySqlCommand command = new MySqlCommand(delete, DB.getConnection());
                        // выполняем запрос    
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запрос подтвержден");
                    }
                }
            }
            else if (countt2 <= 0)
            {
                MessageBox.Show("На складе недостаточно оборудования");
            }

            DB.CloseConnection();
            this.Hide();
        }
            private void eqbox_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void Запросы_Load(object sender, EventArgs e)
            {
                GetComboBoxList();
            }

            private void listButtonControl1_Click(Nevron.Nov.Dom.NEventArgs arg)
            {
                СписокЗапросов sm = new СписокЗапросов();
                sm.Show();
            }
        }
    }