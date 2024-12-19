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

namespace raspisanie
{
    public partial class Raspisanie : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = school.accdb";
        private OleDbConnection myConnection;

        public Raspisanie()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void FillerComboBoxes()
        {
            string query = "SELECT ClassNum,ClassLit FROM ClassTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString() + reader[1].ToString());
            }
            reader.Close();
        }
        private void Raspisanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Raspisanie". При необходимости она может быть перемещена или удалена.
            this.raspisanieTableAdapter.Fill(this.schoolDataSet.Raspisanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.ClassTable". При необходимости она может быть перемещена или удалена.
            this.classTableTableAdapter.Fill(this.schoolDataSet.ClassTable);
            FillerComboBoxes();
            button1.Visible= deleteacces;
        }
        public void LessonNum()
        {
            string quare = " ALTER TABLE Raspisanie ALTER COLUMN LessonNum INT ";
            OleDbCommand command = new OleDbCommand(quare, myConnection);
            command.ExecuteNonQuery();

        }
        public void ChoiceDay()
        {
            LessonNum();
            string query = "SELECT LessonNum,LessonName,Teacher FROM Raspisanie WHERE [DayOfWeek]=" + "'" + day + "'" + "AND [Class]=" + "'" + className + "'" + "ORDER BY LessonNum";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());

            }
            reader.Close();
        }
        private void Raspisanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }
        public string className, day;

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            day = comboBox5.Text;
            try { ChoiceDay(); } catch { }
        }
        public static bool deleteacces;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string item = listBox1.SelectedItem.ToString();
                string str = item.Substring(0, 1);
                int index = int.Parse(str);
                string quare = " DELETE FROM Raspisanie WHERE  [DayOfWeek]=" + "'" + day + "'" + "AND [Class]=" + "'" + className + "'" + "AND [LessonNum]=" + index;
                OleDbCommand command = new OleDbCommand(quare, myConnection);
                command.ExecuteNonQuery();
                ChoiceDay();
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            className = comboBox1.Text;
            try { ChoiceDay(); } catch { }
        }
    }
}
