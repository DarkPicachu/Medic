using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Med.Forms.Window
{
    public partial class KlientForm : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table = new DataTable();
        public string acc { get; set; }
        public KlientForm()
        {
            InitializeComponent();
            string[] items = { };
            reader reader = new reader();
            reader.read("login", "accounts", "login", comboBox1.Text, out items);
            comboBox1.Items.AddRange(items);
            if (GetSet.Update)
            {
                dataBase.openConnection();
                string query = $"select c.id , c.name, c.surname ,c.phone ,c.age ,  ac.login " +
                $"from client c,  accounts ac " +
                $"where   ac.id = c.id and c.id = {GetSet.Id}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                textBox4.Text = table.Rows[0][0].ToString();
                textBox1.Text = table.Rows[0][1].ToString();
                textBox2.Text = table.Rows[0][2].ToString();
                textBox5.Text = table.Rows[0][3].ToString();
                textBox3.Text = table.Rows[0][4].ToString();
                comboBox1.Text = table.Rows[0][5].ToString();
                acc = comboBox1.Text;
                return;
            }
            label1.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetSet.Update)
                Update();
            else Save();
            
            this.Close();
        }
        private void Update()
        {
            float text = textBox3.Text.Length;
            /*if (text != 11 || text == 0)
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            string querystring="";
            if (acc != comboBox1.Text) {
                querystring = $"update client  " +
                $"set name ='{textBox1.Text}', " +
                $"surname = '{textBox2.Text}', " +
                $"phone = '{textBox5.Text}', " +
                $"age = '{textBox3.Text}', " +
                $"account = (select id from accounts where login = '{comboBox1.Text}')  " +
                $"where id = {GetSet.Id}";
            }
            else
            {
                querystring = $"update client  " +
                $"set name ='{textBox1.Text}', " +
                $"surname = '{textBox2.Text}', " +
                $"phone = '{textBox5.Text}', " +
                $"age = '{textBox3.Text}' " +
                $"where id = {GetSet.Id}";
            }
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
        }
        private void Save()
        {
            float text = textBox3.Text.Length;
            if (text != 11 || text != 0)
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string querystring = $"insert into client (name, surname,phone,age,account) " +
                $"values('{textBox1.Text}', '{textBox2.Text}', '{textBox5.Text}', '{textBox3.Text}', (select id from accounts where login = '{comboBox1.Text}'))";
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectionStart;

            comboBox1.Items.Clear();

            int i = comboBox1.SelectedIndex;

            string[] items = { };

            comboBox1.DroppedDown = true;

            reader reader = new reader();
            reader.read("login", "accounts", "login", comboBox1.Text + "%' and role = 3 and login like '%", out items);
            comboBox1.SelectionStart = selected;
            comboBox1.Items.AddRange(items);

            if (i != -1)
                comboBox1.Items.RemoveAt(i);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
