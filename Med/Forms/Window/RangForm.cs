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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Med.Forms.Window
{
    public partial class RangForm : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table = new DataTable();
        public RangForm()
        {
            InitializeComponent();
            if (GetSet.Update)
            {
                dataBase.openConnection();
                string query = $"select r.id, r.name " +
                        $"from rang r " +
                        $"where r.id = {GetSet.Id} ";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                textBox3.Text = table.Rows[0][0].ToString();
                textBox1.Text = table.Rows[0][1].ToString();
                textBox3.ReadOnly = true;
                return;
            }
            label1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
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
            string querystring = $"update rang " +
                $"set name = '{textBox1.Text}' " +
                $"where id = {GetSet.Id}";
            try
            {
                SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());
                dataBase.openConnection();
                cmd.ExecuteNonQuery();
                dataBase.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Save()
        {
            string querystring = $"insert into rang (name) " +
                $"values('{textBox1.Text}')";
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
