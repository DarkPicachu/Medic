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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Med.Forms.Window
{
    public partial class DiagnozForm : Form
    {
        DataBase dataBase = new DataBase();
        public DiagnozForm()
        {
            
            InitializeComponent();
            if (GetSet.Update)
            {
                DataTable table = new DataTable();
                dataBase.openConnection();
                string query = $"select * " +
                    $"from diagnoz " +
                    $"where id = {GetSet.Id}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);

                textBox6.Text = table.Rows[0][0].ToString();
                textBox1.Text = table.Rows[0][1].ToString();
                return;
            }
            label1.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
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
            string diagnoz = textBox1.Text;
            string querystring = $"update diagnoz " +
                $"set diagnoz= '{diagnoz}' " +
                $"where id = {textBox6.Text}";
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
            string diagnoz = textBox1.Text;
            string querystring = $"insert into diagnoz (diagnoz) " +
                $"values('{diagnoz}')";
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

        private void DiagnozForm_Load(object sender, EventArgs e)
        {

        }
    }
}
