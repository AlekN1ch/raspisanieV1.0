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

namespace raspisanie
{
    public partial class Form1 : Form
    {
        public static string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = school.accdb";
        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection= new OleDbConnection(connectionString);
            myConnection.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raspisanie.deleteacces = false;
            Raspisanie raspisanie = new Raspisanie();
            raspisanie.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLesson addLesson = new AddLesson();
            addLesson.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
