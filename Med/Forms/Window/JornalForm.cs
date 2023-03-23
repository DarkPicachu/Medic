using Med.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Med
{
    public partial class JornalForm : Form
    {
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        DataBase dataBase = new DataBase();
        int work = 1;
        public JornalForm(int worker)
        {
            InitializeComponent();

            work = worker;
           /*dataBase.openConnection();
            string query = $"select * from diagnoz";
            string query2 = $"select * from client";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            command = new SqlCommand(query2, dataBase.getConnection());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table2);
            for (int i=0; i<table.Rows.Count; i++)
            {
                comboBox1.Items.Add(table.Rows[i][1]);
            }
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                comboBox2.Items.Add(table2.Rows[i][1] + " " + table2.Rows[i][2]);
            }*/
            string[] items = { };
            reader reader = new reader();
            reader.read("diagnoz", "diagnoz", "diagnoz", comboBox1.Text, out items);
            comboBox1.Items.AddRange(items);
            reader.read("name+' '+ surname", "client", "(name + surname)", comboBox2.Text, out items);
            comboBox2.Items.AddRange(items);


        }        

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectionStart;

            comboBox1.Items.Clear();

            int i = comboBox1.SelectedIndex;
                      
            string[] items = { };

            comboBox1.DroppedDown = true;

            reader reader = new reader();
            reader.read("diagnoz", "diagnoz","diagnoz",comboBox1.Text, out items);
            comboBox1.SelectionStart = selected;
            comboBox1.Items.AddRange(items);
            
            if (i != -1)
                comboBox1.Items.RemoveAt(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime =DateTime.Now;
            string name = comboBox2.Text;
            string diagnoz = comboBox1.Text;
            string heal = textBox4.Text;
            string rest = textBox5.Text;
            string querystring = $"insert into jornal (client, worker, time, diagnoz , healing,rest)values((select  id from client where (name +' ' +surname) = '{name}'), '{work}','{dateTime}', (select  id from diagnoz where (diagnoz) = '{diagnoz}'),'{heal}','{rest}')";
            try
            {
                SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());
                dataBase.openConnection();
                cmd.ExecuteNonQuery();
                dataBase.closeConnection();
            }
            catch 
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            int selected = comboBox2.SelectionStart;
            comboBox2.Items.Clear();
            int i = comboBox2.SelectedIndex;

            string[] items = { };

            comboBox2.DroppedDown = true;

            reader reader = new reader();
            reader.read("Name+' '+ surname", "client", "(name + surname)", comboBox2.Text, out items);
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
