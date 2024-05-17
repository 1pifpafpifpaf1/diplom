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

    public partial class Склад : MetroFramework.Forms.MetroForm
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
        string eq_id = "0";
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView1.SelectedCells[1].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString();
            //Указываем ID выделенной строки в метке
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Магические строки
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            //Метод получения ID выделенной строки в глобальную переменную
            GetSelectedIDString();
        }
        public Склад()
        {
            InitializeComponent();
        }
        //Метод обновления DataGreed
        public void reload_list()
        {
            //Чистим виртуальную таблицу
            table.Clear();
            //Вызываем метод получения записей, который вновь заполнит таблицу
            GetListEq();
        }
        public void GetListEq()
        {
            //Открываем соединение
            DB.OpenConnection();
            //Запрос для вывода строк в БД
            string commandStr = "SELECT " +
                "eq_sklad.id_eq_sklad AS 'Код', " +
                "equipment.eq_name AS 'Название', " +
                "eq_sklad.id_sklad AS 'Склад', " +
                "eq_sklad.eq_count AS 'Количество' " +
                                    "FROM eq_sklad " +
                                    $"JOIN equipment ON equipment.id_equipment = eq_sklad.id_equipment WHERE id_sklad = {Auth.auth_role}";
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
            //Отражаем количество записей в ДатаГриде
            int count_rows = dataGridView1.RowCount;
            toolStripLabel2.Text = (count_rows).ToString();
        }
        private void Склад_Load(object sender, EventArgs e)
        {
            GetListEq();
            //dataGridView1.RowHeadersVisible = true;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addeq sm = new addeq();
            sm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            reload_list();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Оборудование sm = new Оборудование();
            sm.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Удаление sm = new Удаление();
            sm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Вработу sm = new Вработу();
            sm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Неисправно sm = new Неисправно();
            sm.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Запрос sm = new Запрос();
            sm.ShowDialog();
        }

        private void Склад_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Запросы sm = new Запросы();
            sm.Show();
        }
    }
}
