using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raspisanie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.lessonsTable". При необходимости она может быть перемещена или удалена.
            this.lessonsTableTableAdapter.Fill(this.raspisanieDataSet.lessonsTable);

        }
    }
}
