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
    public partial class Админ : MetroFramework.Forms.MetroForm
    {
        public Админ()
        {
            InitializeComponent();
        }

        private void Админ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            Админ_оборудование sm = new Админ_оборудование();
            sm.ShowDialog();
        }

        private void Админ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            Админ_сотрудники sm = new Админ_сотрудники();
            sm.ShowDialog();
        }

        private void button3_Click(Nevron.Nov.Dom.NEventArgs arg)
        {
            Админ_склад sm = new Админ_склад();
            sm.ShowDialog();
        }
    }
}
