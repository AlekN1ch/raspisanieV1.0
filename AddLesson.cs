using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace raspisanie
{
    public partial class AddLesson : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = school.accdb";
        private OleDbConnection myConnection;
        public ListBox listBox1=new ListBox();
        public ListBox listBox2 = new ListBox();
        
        public AddLesson()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddLesson_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.TeachersTable". При необходимости она может быть перемещена или удалена.
            this.teachersTableTableAdapter.Fill(this.schoolDataSet.TeachersTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.ClassTable". При необходимости она может быть перемещена или удалена.
            this.classTableTableAdapter.Fill(this.schoolDataSet.ClassTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Raspisanie". При необходимости она может быть перемещена или удалена.
            this.raspisanieTableAdapter.Fill(this.schoolDataSet.Raspisanie);
            Filler();

        }
        public void FillerClasses()
        {
            string query = "SELECT ClassNum,ClassLit FROM ClassTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString()+ reader[1].ToString());
            }
            reader.Close();

        }
        public void FillerTeachers()
        {
            string query = "SELECT Family,Inicials FROM TeachersTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox2.Items.Clear();
            while (reader.Read())
            {
                listBox2.Items.Add(reader[0].ToString()+" "+ reader[1].ToString());
            }
            reader.Close();

        }
        public void Filler()
        { 
            FillerClasses();
            FillerTeachers();
            comboBox1.Items.Clear();
            comboBox4.Items.Clear();
            foreach (var item in listBox1.Items)
            {
                comboBox1.Items.Add(item.ToString());
            }
            foreach (var item in listBox2.Items)
            {
                comboBox4.Items.Add(item.ToString());
            }
            comboBox1.Items.Add("Добавить класс");
            comboBox4.Items.Add("Добавить учителя");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int acces = 0;
            if (comboBox1.Text == string.Empty || comboBox1.Text == "Добавить класс") { MessageBox.Show("Класс не выбран"); }
            else acces = 1;
            if (comboBox2.Text == string.Empty ) { MessageBox.Show("Предмет не выбран"); }
            else acces = 2;
            if (comboBox4.Text == string.Empty || comboBox4.Text == "Добавить учителя") { MessageBox.Show("Учитель не выбран"); }
            else acces = 3;
            if (comboBox3.Text == string.Empty) { MessageBox.Show("Урок не выбран"); }
            else acces = 4;
            if (comboBox5.Text == string.Empty) { MessageBox.Show("День недели не выбран"); }
            else acces = 5;
            if (acces == 5)
            {
                string query = "INSERT INTO Raspisanie ([DayOfWeek],[LessonNum],[LessonName],[Class],[Teacher]) VALUES " + "('" + comboBox5.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + comboBox4.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Урок добавлен в расписание");
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text =="Добавить класс")
            {
                AddComponent.AddVid = "Добавить класс";
                AddComponent addComponent = new AddComponent();
                addComponent.Show();
                
                this.Close();

            }
               
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Добавить учителя")
            {
                AddComponent.AddVid = "Добавить учителя";
                AddComponent addComponent = new AddComponent();
                addComponent.Show();
                this.Close();
            }
            
        }

        private void AddLesson_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raspisanie.deleteacces = true;
            Raspisanie raspisanie = new Raspisanie();
            raspisanie.Show();
        }
    }
}
