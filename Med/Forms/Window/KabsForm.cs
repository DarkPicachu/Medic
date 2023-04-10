using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Med.Forms.Window
{
    public partial class KabsForm : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table = new DataTable();
        public KabsForm()
        {
            InitializeComponent();
            if (GetSet.Update)
            {
                dataBase.openConnection();
                string query =  $"select cb.id , r.name " +
                        $"from cabinets cb, rang r " +
                        $"where r.id = cb.rang " +
                        $"and cb.id = {GetSet.Id}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                textBox1.Text = table.Rows[0][0].ToString();
                comboBox1.Text = table.Rows[0][1].ToString();
                textBox1.ReadOnly = true;               

            }
            string[] items = { };
            reader reader = new reader();
            reader.read("name", "rang", "name", "", out items);
            comboBox1.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetSet.Update)
                Update();
            else 
                Save();
            
            this.Close();
        }
        private void Update()
        {
            int cab = Convert.ToInt32(textBox1.Text);
            string rang = comboBox1.Text;
            string querystring = $"update cabinets " +
                $"set rang = (select id from rang where name = '{rang}') " +
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
            int cab = Convert.ToInt32(textBox1.Text);
            string rang = comboBox1.Text;
            string querystring = $"insert into cabinets(id,rang) " +
                $"values('{cab}', (select id from rang where name = '{rang}'))";
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }
    }
}
