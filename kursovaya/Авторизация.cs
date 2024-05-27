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
using System.Threading;

namespace kursovaya
{
    public partial class Авторизация : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        static string sha256(string randomString)
        {
            //Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        public Авторизация()
        {
            InitializeComponent();
        }
        public int Connection(string login, string password)
        {


            DB.OpenConnection();
            //Выбор всех данных из таблицы staff и их фильтрование по подходящим логину и паролю
            string commandStr = $"SELECT * FROM staff WHERE log_sotr = '{login}' AND pass_sotr = '{password}'";
            MySqlCommand comm1 = new MySqlCommand(commandStr, DB.getConnection());
            int k = Convert.ToInt32(comm1.ExecuteScalar());
            if (k != 0)
            {
                //Выбор столбца rang в зависимости от логина и пароля
                string commandStr2 = $"SELECT rang_sotr FROM staff WHERE log_sotr = '{login}' AND pass_sotr = '{password}'";
                MySqlCommand comm2 = new MySqlCommand(commandStr2, DB.getConnection());
                Auth.auth_role = Convert.ToInt32(comm2.ExecuteScalar());
                string commandStr3 = $"SELECT id_sotr FROM staff WHERE log_sotr = '{login}' AND pass_sotr = '{password}'";
                MySqlCommand comm3 = new MySqlCommand(commandStr3, DB.getConnection());
                Auth.auth_id = Convert.ToInt32(comm3.ExecuteScalar());
            }

            //Закрытие соединения
            DB.CloseConnection();
            return Auth.auth_role;
        }
        public void Rang()
        {

            if (Connection(logtext.Text, hashtext.Text) == 0)
            {
                MessageBox.Show("Неверные данные");
            }
            else if (Connection(logtext.Text, hashtext.Text) == 3)
            {
                MessageBox.Show($"Вы авторизированы как Админ");
                //Скрытие данной формы и запуск следующей в зависимости от введёных данных
                Админ sm = new Админ();
                sm.ShowDialog();
                this.Hide();
            }
            else if (Connection(logtext.Text, hashtext.Text) == Auth.auth_role)
            {
                MessageBox.Show($"Вы авторизированы как управляющий {Auth.auth_role} склада");
                //Скрытие данной формы и запуск следующей в зависимости от введёных данных
                Склад sm = new Склад();
                sm.ShowDialog();
                this.Hide();
            }

        }


        private void Авторизация_Load(object sender, EventArgs e)
        {
            
        }


        private void hashtext_TextChanged(object sender, EventArgs e)
        {
            hashtext.Text = sha256(passtext.Text);
        }
        private void Авторизация_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            hashtext.Text = sha256(passtext.Text);
            Rang();
            /*Thread myThread1 = new Thread(Rang);
            myThread1.SetApartmentState(ApartmentState.STA);
            myThread1.Start();*/
        }


    }
}
