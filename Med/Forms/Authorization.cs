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

            string querystring = $"select ac.rol, w.id, ac.id from accounts ac, workers w where ac.login = '{login}' and ac.password='{password}' and ac.id = w.account";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
                role = Convert.ToInt32(table.Rows[0][0]);
                idaccount = Convert.ToInt32(table.Rows[0][1]);
                GetSet.Idworker = idaccount;
                JornalForm medKart = new JornalForm();
                GetSet.Idacc = Convert.ToInt32(table.Rows[0][2]);
                MainWindow mainWindow = new MainWindow();
                if (role == 1)
                {
                    mainWindow.Show();
                    this.Hide();
                }
                else if (role == 2)
                {
                    mainWindow.Show();
                }
                else if (role == 3)
                {
                    MessageBox.Show("Нет прав");
                }
            }
            catch
            {
                label3.Visible = true;
            }
        }
    }
}
