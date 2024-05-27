using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Админ_регистрация : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        private MetroTextBox[] metroTextFields;
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

        public Админ_регистрация()
        {
            InitializeComponent();
            metroTextFields = new MetroTextBox[] {fiotext, phonetext, posttext, logtext, passtext};
        }

        private void Админ_регистрация_Load(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click_1(Nevron.Nov.Dom.NEventArgs arg)
        {
            foreach (MetroTextBox metroTextField in metroTextFields)
            {
                if (string.IsNullOrWhiteSpace(metroTextField.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, заполните все поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Проверка ФИО
            string fio = fiotext.Text;
            if (fio.Split(' ').Length < 3 || !System.Text.RegularExpressions.Regex.IsMatch(fio, @"^[а-яА-ЯёЁa-zA-Z\s]+$"))
            {
                MetroFramework.MetroMessageBox.Show(this, "ФИО должно содержать минимум три слова и только буквы.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка номера телефона
            string phone = phonetext.Text;
            if (phone.Length != 11 || phone[0] != '8' || !long.TryParse(phone, out _))
            {
                MetroFramework.MetroMessageBox.Show(this, "Номер телефона должен начинаться с 8 и содержать 11 цифр.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hashtext.Text = sha256(passtext.Text);
            string post = posttext.Text;
            string log = logtext.Text;
            string pass = hashtext.Text;
            int rang = Convert.ToInt32(rangtext.Text);
            DB.OpenConnection();
            string commandStr = $"SELECT id_sotr FROM staff WHERE log_sotr = ('{log}')";
            MySqlCommand comm = new MySqlCommand(commandStr, DB.getConnection());
            int countt = Convert.ToInt32(comm.ExecuteScalar());
            if (countt > 0)
            {
                MessageBox.Show($"Логин уже существует");
            }
            else if (countt == 0)
            {
                string eq = $"INSERT INTO staff (fio_sotr, phone_sotr, post_sotr, log_sotr, pass_sotr, rang_sotr) VALUES ('{fio}','{phone}','{post}','{log}','{pass}','{rang}')";
                MySqlCommand command = new MySqlCommand(eq, DB.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show($"Сотрудник добавлен");
            }
            DB.CloseConnection();
            this.Hide();
        }
    }
}
