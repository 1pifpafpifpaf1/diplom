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
    public partial class Оборудование : MetroFramework.Forms.MetroForm
    {
        DataBase DB = new DataBase();
        //DataAdapter представляет собой объект Command , получающий данные из источника данных.
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        //Объявление BindingSource, основная его задача, это обеспечить унифицированный доступ к источнику данных.
        private BindingSource bSource = new BindingSource();
        //DataSet - расположенное в оперативной памяти представление данных, обеспечивающее согласованную реляционную программную 
        //модель независимо от источника данных.DataSet представляет полный набор данных, включая таблицы, содержащие, упорядочивающие 
        //и ограничивающие данные, а также связи между таблицами.
        private DataSet ds = new DataSet();
        //Представляет одну таблицу данных в памяти.
        private DataTable table = new DataTable();
        //Переменная для ID записи в БД, выбранной в гриде. Пока она не содердит значения, лучше его инициализировать с 0
        //что бы в БД не отправлялся null
        string id_selected_rows = "0";
        public Оборудование()
        {
            InitializeComponent();
        }
        public void GetListEq()
        {
            //Запрос для вывода строк в БД
            string commandStr = "SELECT id_equipment AS 'Код', eq_name AS 'Название' FROM equipment";
            //Открываем соединение
            DB.OpenConnection();
            //Объявляем команду, которая выполнить запрос в соединении conn
            MyDA.SelectCommand = new MySqlCommand(commandStr, DB.getConnection());
            //Заполняем таблицу записями из БД
            MyDA.Fill(table);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource.DataSource = table;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView1.DataSource = bSource;
            //Закрываем соединение
            DB.CloseConnection();
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount;
            label2.Text = (count_rows).ToString();
        }

        private void Оборудование_Load(object sender, EventArgs e)
        {
            DB.OpenConnection();
            GetListEq();
            dataGridView1.RowHeadersVisible = true;
            //Растягивание полей грида
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
        }
    }
}
