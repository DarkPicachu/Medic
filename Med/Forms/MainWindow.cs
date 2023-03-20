using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic.Logging;
using System.Reflection;

namespace Med.Forms
{

    
    public partial class MainWindow : Form
    {
       

        DataGridView dgw = new DataGridView();

        DataBase dataBase = new DataBase();
        string queryString = "";
        public MainWindow(int role)
        {
            InitializeComponent();
            CreateCollumns();
            RefresDataGrid(dataGridView1, 1);
            searchtags(1);

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
            for (int i=1; i<=tabControl1.TabCount; i++)
            {
                DataGridView dgw = new DataGridView();
                dgw = (tabControl1.Controls["tab" + i] as TabPage).Controls["dataGridView" + i] as DataGridView;

                switch (i)
                {
                    case 1:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("client", "client");
                        dgw.Columns.Add("worker", "worker");
                        dgw.Columns.Add("time", "time");
                        dgw.Columns.Add("diagnoz", "diagnoz");
                        dgw.Columns.Add("healing", "healing");
                        dgw.Columns.Add("rest", "rest");
                        break;
                    case 2:
                        dgw.Columns.Add("id", "id");
                        dgw.Columns.Add("Name", "Name");
                        dgw.Columns.Add("Surname", "Surname");
                        dgw.Columns.Add("phone", "phone");
                        dgw.Columns.Add("Age", "Age");
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

        private void CreateColumns(DataGridView dgw, int index)
        {
           /* dgw.Columns.Clear();
            switch (index)
            {
                case 1:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("client", "client");
                    dgw.Columns.Add("worker", "worker");
                    dgw.Columns.Add("time", "time");
                    dgw.Columns.Add("diagnoz", "diagnoz");
                    dgw.Columns.Add("healing", "healing");
                    dgw.Columns.Add("rest", "rest");
                    break;
                case 2:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("Name", "Name");
                    dgw.Columns.Add("Surname", "Surname");
                    dgw.Columns.Add("phone", "phone");
                    dgw.Columns.Add("Age", "Age");
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


            }*/


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

        private void RefresDataGrid(DataGridView dgw, int table_index)
        {

            dgw.Rows.Clear();
            switch (table_index)
            {
                case 1:
                    queryString = $"select j.id , (c.Name+ ' ' + c.Surname),  (w.name+' '+w.surname), j.time, d.diagnoz , j.healing, j.rest\r\nfrom client c, workers w, jornal j , Diagnoz d\r\nwhere c.id = j.client and w.id = j.worker and d.id = j.diagnoz";
                    break;
                case 2:
                    queryString = $"select c.id , c.Name, c.Surname ,c.phone ,c.Age ,  (ac.login +';' +ac.password)\r\nfrom client c,  accounts ac\r\nwhere   ac.id = c.id";
                    break;
                case 3:
                    queryString = $"select d.id, d.diagnoz\r\nfrom Diagnoz d";
                    break;
                case 4:
                    queryString = $"select wr.id, wr.name, wr.surname, r.name, cab.id,  ac.login+ ';'+ac.password\r\nfrom workers wr, cabinets cab, Rang r,accounts ac\r\nwhere  ac.id =wr.id and r.id = cab.rang and cab.id = wr.cabinet";
                    break;
                case 5:
                    queryString = $"select ac.id, ac.login, ac.password, rl.rols\r\nfrom accounts ac, rols rl\r\nwhere rl.id = ac.id";
                    break;
                case 6:
                    queryString = $"select r.id, r.name\r\nfrom Rang r";
                    break;
                case 7:
                    queryString = $"select rl.id , rl.rols\r\nfrom rols rl";
                    break;
                case 8:
                    queryString = $"select cb.id , r.name\r\nfrom cabinets cb, Rang r\r\nwhere r.id = cb.rang";
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

        }

        private void search()
        {

            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());
            command.ExecuteNonQuery();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchtags(int index)
        {
            searchPole.Items.Clear();
            searchPole.Text = "";
            List<string> tags = new List<string> { };
            switch (index)
            {
                case 1:
                    tags = new List<string> { "id", "Клиент", "Лечащий врач", "Дата прихода", "Диагноз", "Лечение", "Отдых" };
                    break;
                case 2:
                    tags = new List<string> { "id", "Имя", "Фамилия", "Номер телефона", "Возраст" };
                    break;
                case 3:
                    tags = new List<string> { "id", "Диагноз" };
                    break;
                case 4:
                    tags = new List<string> { "id", "Имя", "Фамилия", "Должность", "Кабинет", "Логин и пароль" };
                    break;
                case 5:
                    tags = new List<string> { "id", "Логин", "Пароль", "Роль" };
                    break;
                case 6:
                    tags = new List<string> { "id", "Должность" };
                    break;
                case 7:
                    tags = new List<string> { "id", "Роль" };
                    break;
                case 8:
                    tags = new List<string> { "id", "Должность" };
                    break;
            }
            string[] tagsstring = tags.ToArray();
            searchPole.Items.AddRange(tagsstring);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = tabControl1.SelectedIndex + 1;

            dgw = (tabControl1.Controls["tab" + index] as TabPage).Controls["dataGridView" + index] as DataGridView;
           
            /*switch (index)
            {
                case 1:
                    dgw = dataGridView1;
                    break;
                case 2:
                    dgw = dataGridView2;
                    break;
                case 3:
                    dgw = dataGridView3;
                    break;
                case 4:
                    dgw = dataGridView4;
                    break;
                case 5:
                    dgw = dataGridView5;
                    break;
                case 6:
                    dgw = dataGridView6;
                    break;
                case 7:
                    dgw = dataGridView7;
                    break;
                case 8:
                    dgw = dataGridView8;
                    break;
            }*/

            RefresDataGrid(dgw, index);
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
                RefresDataGrid(dgw, index);
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
    }
}
