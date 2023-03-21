using System.Data.SqlClient;
using System.Data;

namespace Med.Forms
{

    public partial class Authorization : Form
    {
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
           
            int role = 0;
            int idaccount = 0;
            
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select rol, id from accounts where login = '{login}' and password='{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            role = Convert.ToInt32(table.Rows[0][0]);
            idaccount = Convert.ToInt32(table.Rows[0][1]);
            JornalForm medKart = new JornalForm(role);
            MainWindow mainWindow = new MainWindow(role);
            if (role == 1)
            {
                mainWindow.Show();
                mainWindow.accNames(textBox1.Text, textBox2.Text);
                this.Hide();
            }
            else if (role == 2)
            {
                mainWindow.Show();
            }
            else if (role == 3)
            {
                medKart.ShowDialog();
                this.Hide();
            }




        
        }
    }
}
