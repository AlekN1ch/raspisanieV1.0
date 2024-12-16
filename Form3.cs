using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace raspisanie
{
    public partial class Form3 : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = raspisanie.accdb";
        private OleDbConnection myConnection;

        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "raspisanieDataSet.lessonsTable". При необходимости она может быть перемещена или удалена.
            this.lessonsTableTableAdapter.Fill(this.raspisanieDataSet.lessonsTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty) 
            {
                MessageBox.Show("Учитель не выбран");
            }
            else
            {
                if (comboBox3.Text == string.Empty) MessageBox.Show("Номер урока не выбран");
                else
                {
                    if (comboBox2.Text == string.Empty) MessageBox.Show("Класс не выбран");
                    else 
                    {
                        string query = "INSERT INTO lessonsTable ([teacher],[lessson],[classOn]) VALUES " + "('" + comboBox1.Text+ "','" + comboBox3.Text + "','" + comboBox2.Text + "')";
                        OleDbCommand command = new OleDbCommand(query, myConnection);
                        command.ExecuteNonQuery();
                        this.lessonsTableTableAdapter.Fill(this.raspisanieDataSet.lessonsTable);
                    }
                }
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.lessonsTableTableAdapter.Fill(this.raspisanieDataSet.lessonsTable);
        }
    }
}
