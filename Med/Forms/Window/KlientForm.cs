using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med.Forms.Window
{
    public partial class KlientForm : Form
    {
        DataBase dataBase = new DataBase();
        public KlientForm()
        {
            InitializeComponent();
            string[] items = { };
            reader reader = new reader();
            reader.read("login", "accounts", "login", comboBox1.Text, out items);
            comboBox1.Items.AddRange(items);
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

        }
        private void Save()
        {
            if (textBox3.Text.Length != 11)
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
