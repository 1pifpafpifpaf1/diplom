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
    public partial class СписокЗапросов : MetroFramework.Forms.MetroForm
    {
        public СписокЗапросов()
        {
            InitializeComponent();
        }
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

        public void GetListEq()
        {
            //Открываем соединение
            DB.OpenConnection();
            //Запрос для вывода строк в БД
            string commandStr = "SELECT " +
                "request.id_request AS 'Код', " +
                "equipment.eq_name AS 'Название', " +
                "request.id_sklad AS 'Склад', " +
                "request.eq_count AS 'Количество', " +
                "request.data_req AS 'Дата запроса' " +
                                    "FROM request " +
                                    $"JOIN equipment ON equipment.id_equipment = request.id_equipment WHERE NOT id_sklad = {Auth.auth_role}";
            //Объявляем команду, которая выполнит запрос в соединении
            MyDA.SelectCommand = new MySqlCommand(commandStr, DB.getConnection());
            //Заполняем таблицу записями из БД
            MyDA.Fill(table);
            //Указываем, что источником данных в bindingsource является заполненная выше таблица
            bSource.DataSource = table;
            //Указываем, что источником данных ДатаГрида является bindingsource 
            dataGridView1.DataSource = bSource;
            //Закрываем соединение
            DB.CloseConnection();
        }

        private void СписокЗапросов_Load(object sender, EventArgs e)
        {
            GetListEq();
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Чистим виртуальную таблицу
            table.Clear();
            //Вызываем метод получения записей, который вновь заполнит таблицу
            GetListEq();
        }
    }
}
