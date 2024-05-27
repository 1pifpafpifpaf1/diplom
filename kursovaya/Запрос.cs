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
    public partial class Запрос : MetroFramework.Forms.MetroForm
    {
        public Запрос()
        {
            InitializeComponent();
        }
        DataBase DB = new DataBase();
        static int sklad = 0;
        void GetComboBoxList()
        {
            if (Auth.auth_role == 1)
            {
                sklad = 2;
            }
            else
            {
                sklad = 1;
            }
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
            string sql_list_users = $"SELECT id_eq_sklad, id_equipment FROM eq_sklad WHERE id_sklad ={sklad}";
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

        private void Запрос_Load(object sender, EventArgs e)
        {
            GetComboBoxList();
        }

        private void reqbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            if (Auth.auth_role == 1)
            {
                sklad = 2;
            }
            else
            {
                sklad = 1;
            }
            DB.OpenConnection();
            int id_eq = Convert.ToInt32(eqbox.SelectedValue);
            int count = Convert.ToInt32(boxcount.SelectedItem);
            string commandStr = $"SELECT eq_count FROM eq_sklad WHERE id_equipment = {id_eq} AND id_sklad = {sklad}";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt >= count)
            {
                try
                {
                    DateTime data_des = DateTime.Now;
                    var data = data_des.ToString("yyyy-MM-dd H:mm:ss");
                    string query = $"INSERT INTO request (id_equipment, id_sotr, eq_count, id_sklad, data_req) VALUES ('{id_eq}', '{Auth.auth_id}','{count}', '{Auth.auth_role}', '{data}')";
                    // объект для выполнения SQL-запроса
                    MySqlCommand command1 = new MySqlCommand(query, DB.getConnection());
                    // выполняем запрос
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Запрошено");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex);
                }
            }
            else
            {
               MessageBox.Show("Ошибка: Недостаточно оборудования");
            }
            DB.CloseConnection();
            this.Hide();
        }

        private void listButtonControl1_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            Склад2 sm = new Склад2();
            sm.Show();
        }
    }
}
