﻿using Med.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Med
{
    public partial class JornalForm : Form
    {
        DataBase dataBase = new DataBase();
        int work = 1;
        public JornalForm(int worker)
        {
            InitializeComponent();

            work = worker;
            string[] items = { };

            reader reader = new reader();

            reader.read("diagnoz", "Diagnoz", "diagnoz", comboBox1.Text, out items);
            comboBox1.Items.AddRange(items);
            reader.read("Name+' '+ Surname", "client", "(Name + Surname)", comboBox2.Text, out items);
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
            reader.read("diagnoz", "Diagnoz","diagnoz",comboBox1.Text, out items);
            comboBox1.SelectionStart = selected;
            comboBox1.Items.AddRange(items);
            
            if (i != -1)
                comboBox1.Items.RemoveAt(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader reader = new reader();
            DateTime dateTime =DateTime.Now;
            string name = comboBox2.Text;
            string diagnoz = comboBox1.Text;
            string heal = textBox4.Text;
            string rest = textBox5.Text;
            string querystring = $"insert into jornal (client, worker, time, diagnoz , healing,rest)values((select  id from client where (Name +' ' +Surname) = '{name}'), '{work}','{dateTime}', (select  id from Diagnoz where (diagnoz) = '{diagnoz}'),'{heal}','{rest}')";
            SqlCommand cmd = new SqlCommand(querystring,dataBase.getConnection());
            dataBase.openConnection();
            cmd.ExecuteNonQuery();
            dataBase.closeConnection();
            reader.refresh(work);
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
