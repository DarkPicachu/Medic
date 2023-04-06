using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Med.Forms.Window
{
    public partial class AccountForm : Form
    {
        DataBase dataBase = new DataBase();
        DataTable table = new DataTable();
        
        
        public AccountForm()
        {
            InitializeComponent();
            if(GetSet.Update)
            {
                dataBase.openConnection();
                string query = $"select ac.id, ac.login, ac.password, rl.rols " +
                    $"from accounts ac, rols rl " +
                    $"where rl.id = ac.id " +
                    $"and ac.id = {GetSet.Idacc})";

                SqlCommand command = new SqlCommand(query, dataBase.getConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                textBox3.Text = table.Rows[0][0].ToString();
                comboBox1.Text = table.Rows[0][3].ToString();
                textBox1.Text = table.Rows[0][1].ToString();
                textBox2.Text = table.Rows[0][2].ToString();
                return;
            }
            string[] items = { };
            reader reader = new reader();
            reader.read("rols", "rols", "rols", comboBox1.Text, out items);
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
            string login = textBox1.Text;
            string password = textBox2.Text;
            string rols = comboBox1.Text;
            string querystring = $"update accounts set login = '{login}', " +
                $"password = '{password}', " +
                $"rol = (select id from rols where rols = '{rols}') " +
                $"where id = {GetSet.Idacc}";
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
            string login = textBox1.Text;
            string password = textBox2.Text;
            string rols = comboBox1.Text;
            string querystring = $"insert into accounts (login,password,rol) " +
                $"values('{login}','{password}',(select id from rols where rols = '{rols}'))";
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
