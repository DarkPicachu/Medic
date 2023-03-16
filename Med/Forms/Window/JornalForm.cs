using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data.SqlClient;

namespace Med
{
    public partial class JornalForm : Form
    {
        DataBase dataBase = new DataBase();
        int work = 1;
        public JornalForm(int worker)
        {
            InitializeComponent();
            comboBox1.MaxDropDownItems = 8;
            work = worker;
        }        

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectionStart;
            comboBox1.Items.Clear();
            int i = comboBox1.SelectedIndex;
                      
            string[] items = { };

            comboBox1.DroppedDown = true;

            reader reader = new reader();
            reader.read("diagnoz", "Diagnoz","diagnoz",comboBox1.Text, out items);
            comboBox1.SelectionStart = selected;
            comboBox1.Items.AddRange(items);
            
            if (i != -1)
                comboBox1.Items.RemoveAt(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today;
            string name = comboBox2.Text;
            string diagnoz = comboBox1.Text;
            string heal = textBox4.Text;
            string rest = textBox5.Text;
            string querystring = $"insert into jornal (client, worker, time, diagnoz , healing,rest)values((select  id from client where (Name +' ' +Surname) = '"+name+"'), "+work+", (select  iddiaonoz from Diagnoz where (diagnoz) = '"+diagnoz+"'),'"+heal +"','"+rest +"')";
            SqlCommand cmd = new SqlCommand(querystring,dataBase.getConnection());
            dataBase.openConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand= cmd;
            dataBase.closeConnection();


        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            int selected = comboBox2.SelectionStart;
            comboBox2.Items.Clear();
            int i = comboBox2.SelectedIndex;

            string[] items = { };

            comboBox2.DroppedDown = true;

            reader reader = new reader();
            reader.read("Name+' '+ Surname", "client", "(Name + Surname)", comboBox2.Text, out items);
            comboBox2.SelectionStart = selected;
            comboBox2.Items.AddRange(items);

            if (i != -1)
                comboBox2.Items.RemoveAt(i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
