using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kursovaya
{
    internal static class Getcombo
    {
        static  DataBase DB = new DataBase();
        static public bool GetComboBox(ComboBox comboBox1, string id_equipment, string eq_name, string tablename)
        {
            //Открываем соединение
            DB.OpenConnection();
            DataTable list_eq_table = new DataTable();
            MySqlCommand list_eq_command = new MySqlCommand();
            //Формируем столбцы для комбобокса списка ЦП
            list_eq_table.Columns.Add(new DataColumn(id_equipment, System.Type.GetType("System.Int32")));
            list_eq_table.Columns.Add(new DataColumn(eq_name, System.Type.GetType("System.String")));
            //Настройка видимости полей комбобокса
            comboBox1.DataSource = list_eq_table;
            comboBox1.ValueMember = id_equipment;
            comboBox1.DisplayMember = eq_name;
            //Формируем строку запроса 
            string sql_list_eq = $"SELECT {id_equipment}, {eq_name} FROM {tablename}";
            list_eq_command.CommandText = sql_list_eq;
            list_eq_command.Connection = DB.getConnection();
            //Формирование списка ЦП для combobox'a
            MySqlDataReader list_eq_reader;
            try
            {
                //Инициализируем ридер
                list_eq_reader = list_eq_command.ExecuteReader();
                while (list_eq_reader.Read())
                {
                    DataRow rowToAdd = list_eq_table.NewRow();
                    rowToAdd[id_equipment] = Convert.ToInt32(list_eq_reader[0]);
                    rowToAdd[eq_name] = list_eq_reader[1].ToString();
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
            return true;
        }
    }
    
}
