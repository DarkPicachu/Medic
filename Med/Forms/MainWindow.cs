using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Med.Forms
{


    public partial class MainWindow : Form
    {


        DataGridView dgw = new DataGridView();

        DataBase dataBase = new DataBase();
        string queryString = "";
        int role;
        public MainWindow(int id)
        {
            InitializeComponent();
            CreateCollumns();
            RefresDataGrid("", "", "", "", "", "", "");
            searchtags(1);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            queryString = $"select (w.name+' '+w.surname), r.id\r\nfrom workers w , rols r, accounts ac\r\nwhere r.id = ac.rol and ac.id = w.account and w.id = {id}";


            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string name = table.Rows[0][0].ToString();
            role = Convert.ToInt32(table.Rows[0][1]);
            accName.Text = name;

            dgw = dataGridView1;
            if (role == 1)
                return;

            tab5.Parent = null;
            tab4.Parent = null;
            tab7.Parent = null;
            tab8.Parent = null;
            tab6.Parent = null;

        }

        public void accNames(string log, string pas)
        {
            queryString = $"select w.name +' '+w.surname from workers w, accounts acc where (acc.login + acc.password = '" + log + pas + "') and acc.id = w.account";

            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                accName.Text = reader.GetString(0);

            reader.Close();
        }

        public void CreateCollumns()
        {
            for (int i = 1; i <= tabControl1.TabCount; i++)
            {
                DataGridView dgw = new DataGridView();
                dgw = (tabControl1.Controls["tab" + i] as TabPage).Controls["dataGridView" + i] as DataGridView;

                switch (i)
                {
                    case 1:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("client", "Клиент");
                        dgw.Columns.Add("worker", "Врач");
                        dgw.Columns.Add("time", "Время");
                        dgw.Columns.Add("diagnoz", "Диагноз");
                        dgw.Columns.Add("healing", "Лечение");
                        dgw.Columns.Add("rest", "Отдых");
                        break;
                    case 2:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("name", "Name");
                        dgw.Columns.Add("surname", "Surname");
                        dgw.Columns.Add("phone", "phone");
                        dgw.Columns.Add("age", "Age");
                        break;
                    case 3:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("diagnoz", "diagnoz");
                        break;
                    case 4:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("name", "name");
                        dgw.Columns.Add("surname", "surname");
                        dgw.Columns.Add("name", "name");
                        dgw.Columns.Add("cabinet", "cabinet");
                        dgw.Columns.Add("account", "account");
                        break;
                    case 5:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("login", "Логин");
                        dgw.Columns.Add("password", "Пароль");
                        dgw.Columns.Add("rol", "Роль");
                        break;
                    case 6:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("name", "name");
                        break;
                    case 7:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("rols", "rols");
                        break;
                    case 8:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("rang", "rang");
                        break;


                }
            }

        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record, int index)
        {
            switch (index)
            {
                case 1:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3).ToString("d"), record.GetString(4), record.GetString(5), record.GetString(6));
                    break;
                case 2:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4));
                    break;
                case 3:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
                    break;
                case 4:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5));
                    break;
                case 5:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
                    break;
                case 6:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
                    break;
                case 7:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
                    break;
                case 8:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
                    break;
            }
        }

        public void RefresDataGrid(string first, string second, string third, string fourth, string fifth, string sixth, string seventh)
        {
            int table_index;
            indexpage(out table_index, out dgw);

            dgw.Rows.Clear();
            switch (table_index)
            {
                case 1:
                    queryString = $"select j.id , (c.name+ ' ' + c.surname),  (w.name+' '+w.surname), j.time, d.diagnoz , j.healing, j.rest " +
                        $"from client c, workers w, jornal j , diagnoz d " +
                        $"where c.id = j.client and w.id = j.worker and d.id = j.diagnoz " +
                        $"and j.id like '%{first}%' and concat (c.name, c.surname) like '%{second}%' and concat (w.name, w.surname) like '%{third}%' and j.time like '%{fourth}%' and d.diagnoz like '%{fifth}%' and j.healing like '%{sixth}%' and j.rest like '%{seventh}%'";

                    break;
                case 2:
                    queryString = $"select c.id , c.name, c.surname ,c.phone ,c.age ,  (ac.login +';' +ac.password) " +
                        $"from client c,  accounts ac " +
                        $"where   ac.id = c.id and c.id like '%{first}%' and c.name like '%{second}%' and c.surname like '%{third}%' and c.phone like '%{fourth}%' and c.age like '%{fifth}%' and concat (ac.login,ac.password) like '%{sixth}%'";
                    break;
                case 3:
                    queryString = $"select d.id, d.diagnoz " +
                        $"from Diagnoz d " +
                        $"where d.id like '%{first}%' and d.diagnoz like '%{second}%'";
                    break;
                case 4:
                    queryString = $"select wr.id, wr.name, wr.surname, r.name, cab.id,  ac.login+ ';'+ac.password " +
                        $"from workers wr, cabinets cab, rang r,accounts ac " +
                        $"where  ac.id =wr.id and r.id = cab.rang and cab.id = wr.cabinet " +
                        $"and wr.id like '%{first}%' and wr.name like '%{second}%' and wr.surname like '%{third}%' and r.name like '%{fourth}%' and cab.id like '%{fifth}%' and concat (ac.login , ac.password) like '%{sixth}%'";
                    break;
                case 5:
                    queryString = $"select ac.id, ac.login, ac.password, rl.rols " +
                        $"from accounts ac, rols rl " +
                        $"where rl.id = ac.id " +
                        $"and ac.id like '%{first}%' and ac.login like '%{second}%' and ac.password like '%{third}%' and rl.rols like '%{fourth}%'";
                    break;
                case 6:
                    queryString = $"select r.id, r.name " +
                        $"from rang r " +
                        $"where r.id like '%{first}%' and r.name like '%{second}%'";
                    break;
                case 7:
                    queryString = $"select rl.id , rl.rols " +
                        $"from rols rl " +
                        $"where rl.id like '%{first}%' and rl.rols like '%{second}%'";
                    break;
                case 8:
                    queryString = $"select cb.id , r.name " +
                        $"from cabinets cb, rang r " +
                        $"where r.id = cb.rang " +
                        $"and cb.id like '%{first}%' and r.name like '%{second}%'";
                    break;
            }


            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());


            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader, table_index);
            }
            reader.Close();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            int index;
            indexpage(out index, out dgw);
            int filtrindex = searchPole.SelectedIndex;
            string first = "";
            string second = "";
            string third = "";
            string fourth = "";
            string fifth = "";
            string sixth = "";
            string seventh = "";
            switch (filtrindex + 1)
            {
                case 1:
                    first = searchValues.Text;
                    break;
                case 2:
                    second = searchValues.Text;
                    break;
                case 3:
                    third = searchValues.Text;
                    break;
                case 4:
                    fourth = searchValues.Text;
                    break;
                case 5:
                    fifth = searchValues.Text;
                    break;
                case 6:
                    sixth = searchValues.Text;
                    break;
                case 7:
                    seventh = searchValues.Text;
                    break;
                default:
                    first = searchValues.Text;
                    break;
            }
            RefresDataGrid(first, second, third, fourth, fifth, sixth, seventh);
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchtags(int index)
        {
            searchPole.Items.Clear();
            indexpage(out index, out dgw);
            List<string> tags = new List<string> { };
            for (int i = 0; i < dgw.Columns.Count; i++)
            {
                tags.Add(dgw.Columns[i].Name);
            }
            string[] tagsstring = tags.ToArray();
            searchPole.Text = tagsstring[0];
            searchPole.Items.AddRange(tagsstring);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            indexpage(out index, out dgw);
            RefresDataGrid("", "", "", "", "", "", "");
            searchtags(index);
        }


        private void butDel_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex + 1;
            int id = Convert.ToInt32(dgw[0, dgw.CurrentRow.Index].Value.ToString());
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?",
                "Удаление записи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                deleteRow(index, id);
                RefresDataGrid("", "", "", "", "", "", "");
            }

            this.TopMost = true;
        }
        private void deleteRow(int index, int id)
        {
            string table_name = "";

            switch (index)
            {
                case 1:
                    table_name = "journal";
                    break;
                case 2:
                    table_name = "client";
                    break;
                case 3:
                    table_name = "Diagnoz";
                    break;
                case 4:
                    table_name = "workers";
                    break;
                case 5:
                    table_name = "accounts";
                    break;
                case 6:
                    table_name = "Rang";
                    break;
                case 7:
                    table_name = "rols";
                    break;
                case 8:
                    table_name = "cabinets";
                    break;
            }
            queryString = $"delete from {table_name} where id = '{id}' ";
            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());
            command.ExecuteNonQuery();
        }

        private void indexpage(out int index, out DataGridView dgw)
        {
            index = tabControl1.SelectedIndex + 1;

            dgw = (tabControl1.Controls["tab" + index] as TabPage).Controls["dataGridView" + index] as DataGridView;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            JornalForm jornalForm = new JornalForm(role);
            jornalForm.ShowDialog();
            RefresDataGrid("", "", "", "", "", "", "");
        }
    }
}