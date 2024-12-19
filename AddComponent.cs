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
    public partial class AddComponent : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = school.accdb";
        private OleDbConnection myConnection;
        public static string AddVid;
        public AddComponent()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void AddComponent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.TeachersTable". При необходимости она может быть перемещена или удалена.
            this.teachersTableTableAdapter.Fill(this.schoolDataSet.TeachersTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.ClassTable". При необходимости она может быть перемещена или удалена.
            this.classTableTableAdapter.Fill(this.schoolDataSet.ClassTable);
            if (AddVid == "Добавить класс") { label2.Text = "Номер класса";label3.Text = "Литера класса"; }
            if (AddVid == "Добавить учителя") { label2.Text = "Фамилия учителя"; label3.Text = "Инициалы учителя"; }
            label1.Text= AddVid;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddVid == "Добавить класс")
            {
                string query = "INSERT INTO ClassTable ([ClassNum],[ClassLit]) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Класс добавлен");
                AddLesson addLesson = new AddLesson();
                addLesson.ShowDialog();
                this.Close();
                
            }
            if (AddVid == "Добавить учителя")
            {
                string query = "INSERT INTO TeachersTable ([Family],[Inicials]) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Учитель добавлен");
                AddLesson addLesson = new AddLesson();
                addLesson.ShowDialog();
                this.Close();

            }
        }

        private void AddComponent_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
    }
}
