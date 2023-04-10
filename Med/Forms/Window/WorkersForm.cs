using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med.Forms.Window
{
    public partial class WorkersForm : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table = new DataTable();
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
            if (GetSet.Update)
            {
                dataBase.openConnection();
                string query = $"select wr.id, wr.name, wr.surname,  cab.id,  ac.login " +
                        $"from workers wr, cabinets cab, rang r,accounts ac " +
                        $"where  ac.id =wr.id and r.id = cab.rang and cab.id = wr.cabinet " +
                        $"and wr.id = {GetSet.Id}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                textBox3.Text = table.Rows[0][0].ToString();
                textBox1.Text = table.Rows[0][1].ToString();
                textBox2.Text = table.Rows[0][2].ToString();
                comboBox1.Text = table.Rows[0][3].ToString();
                comboBox2.Text = table.Rows[0][4].ToString();
                return;
            }
            label4.Visible = false;
            textBox3.Visible = false;
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
            string querystring = $"update workers " +
                 $"set name = '{textBox1.Text}', " +
                 $"surname = '{textBox2.Text}', " +
                 $"cabinet = (select id from cabinets where id = '{comboBox1.Text}'), " +
                 $"account = (select id from accounts where login = '{comboBox2.Text}') " +
                 $"where id = {GetSet.Id}";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
