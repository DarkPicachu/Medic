using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med.Forms.Window
{
    public partial class WorkersForm : Form
    {
        DataBase dataBase = new DataBase();
        public WorkersForm()
        {
            InitializeComponent();
            string[] items = { };
            reader reader = new reader();            
            
            List<string> strings = new List<string>();
            string querystring = $"select id from cabinets";
            SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                strings.Add(reader1.GetInt32(0).ToString());
            }
            items = strings.ToArray();
            reader1.Close();

            comboBox1.Items.AddRange(items);
            reader.read("login", "accounts", "login", comboBox1.Text, out items);
            comboBox2.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querystring = $"insert into workers (name, surname,cabinet,account) " +
                 $"values('{textBox1.Text}', '{textBox2.Text}', (select id from cabinets where id = '{comboBox1.Text}'), (select id from accounts where login = '{comboBox2.Text}'))";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
