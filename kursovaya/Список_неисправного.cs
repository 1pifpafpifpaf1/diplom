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
    public partial class Список_неисправного : MetroFramework.Forms.MetroForm
    {
        public Список_неисправного()
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
                "eq_destroyed.id_eq_des AS 'Код', " +
                "equipment.eq_name AS 'Название', " +
                "eq_destroyed.id_sotr AS 'Код сотрудника', " +
                "eq_destroyed.eq_count AS 'Количество', " +
                "eq_destroyed.data_des AS 'Дата назначения' " +
                                    "FROM eq_destroyed " +
                                    $"JOIN equipment ON equipment.id_equipment = eq_destroyed.id_equipment WHERE id_sotr = '{Auth.auth_id}'";
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

        private void Список_неисправного_Load(object sender, EventArgs e)
        {
            GetListEq();
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
