using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;

namespace Med.Forms.Window
{
    public partial class AccountForm : Form
    {
        DataBase dataBase = new DataBase();

        int id = 0;
        bool update = false;
        public int Id { get { return id; } set { id = value; }}
        public bool Update { get { return update; }  set { update = value; } }
        
        public AccountForm()
        {
            InitializeComponent();
            if(update)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
            }
            string[] items = { };
            reader reader = new reader();
            reader.read("rols", "rols", "rols", comboBox1.Text, out items);
            comboBox1.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
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
            this.Close();
        }
        private void Updat()
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string rols = comboBox1.Text;
            string querystring = $"update accounts set login = '1', password = '1', rol = 1 " +
                $"where id = 6";
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
