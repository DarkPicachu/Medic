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
            CreateColumns(dataGridView1,1);
            RefresDataGrid(dataGridView1, 1);
            searchtags(1);

            dgw = dataGridView1;            
            if (role == 1)
                return;

            tabAccounts.Parent = null;
            tabWorkers.Parent = null;
            tabRole.Parent = null;
            tabKab.Parent = null;
            tabDoljnosti.Parent = null;

        }
        
        public void accNames (string log, string pas)
        {
            queryString = $"select w.name +' '+w.surname from workers w, accounts acc where (acc.login + acc.password = '" + log + pas + "') and acc.idaccounts = w.account";

            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());
            

            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                accName.Text = reader.GetString(0);
            
            reader.Close();
        }

        private void CreateColumns(DataGridView dgw, int index)
        {
            dgw.Columns.Clear();
            switch (index)
            { 
                case 1:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("client", "Клиент");
                    dgw.Columns.Add("worker", "Лечащий врач");
                    dgw.Columns.Add("time", "Дата прихода");
                    dgw.Columns.Add("diagnoz", "Диагноз");
                    dgw.Columns.Add("healing", "Лечение");
                    dgw.Columns.Add("rest", "Отдых");
                    break;
                case 2:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("name", "Имя");
                    dgw.Columns.Add("surname", "Фамилия");
                    dgw.Columns.Add("phone", "Номер телефона");
                    dgw.Columns.Add("age", "Возраст");
                    break; 
                case 3:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("diagnoz", "Диагноз");
                    break; 
                case 4:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("name", "Имя");
                    dgw.Columns.Add("surname", "Фамилия");
                    dgw.Columns.Add("rang", "Должность");
                    dgw.Columns.Add("number", "Кабинет");
                    dgw.Columns.Add("log_pas", "Логин и пароль");
                    break;
                case 5:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("login", "Логин");
                    dgw.Columns.Add("password", "Пароль");
                    dgw.Columns.Add("rol", "Роль");
                    break;  
                case 6:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("rang", "Должность");
                    break;  
                case 7:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("rol", "Роль");
                    break;
                case 8:
                    dgw.Columns.Add("id", "id");
                    dgw.Columns.Add("rang", "Должность");
                    break;


            }


        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record, int index)
        {
            switch (index)
            {
                case 1:
                    dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3).ToString("d"), record.GetString(4) ,record.GetString(5), record.GetString(6));
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
                    queryString = $"select j.idjornal , (c.Name+ ' ' + c.Surname),  (w.name+' '+w.surname), j.time, d.diagnoz , j.healing, j.rest\r\nfrom client c, workers w, jornal j , Diagnoz d\r\nwhere c.id = j.client and w.idworker = j.worker and d.iddiaonoz = j.diagnoz";
                    break; 
                case 2:
                    queryString = $"select c.id , c.Name, c.Surname ,c.phone ,c.Age ,  (ac.login +';' +ac.password)\r\nfrom client c,  accounts ac\r\nwhere   ac.idaccounts = c.id";
                    break; 
                case 3:
                    queryString = $"select d.iddiaonoz, d.diagnoz\r\nfrom Diagnoz d";                    
                    break; 
                case 4:
                    queryString = $"select wr.idworker, wr.name, wr.surname, r.name, cab.number,  ac.login+ ';'+ac.password\r\nfrom workers wr, cabinets cab, Rang r,accounts ac\r\nwhere  ac.idaccounts =wr.idworker and r.idrang = cab.rang and cab.number = wr.cabinet";
                    break; 
                case 5:
                    queryString = $"select ac.idaccounts, ac.login, ac.password, rl.rols\r\nfrom accounts ac, rols rl\r\nwhere rl.idrols = ac.idaccounts";
                    break; 
                case 6:
                    queryString = $"select r.idrang, r.name\r\nfrom Rang r";
                    break;
                case 7:
                    queryString = $"select rl.idrols , rl.rols\r\nfrom rols rl";
                    break;
                case 8:
                    queryString = $"select cb.number , r.name\r\nfrom cabinets cb, Rang r\r\nwhere r.idrang = cb.rang";
                    break;
            }

            
            SqlCommand command = new SqlCommand(
                queryString,dataBase.getConnection());


            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw,reader,table_index);
            }
            reader.Close();
        }        

        private void butSearch_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchtags(int index)
        {
            searchPole.Items.Clear();
            searchPole.Text = "";
            List<string> tags= new List<string> { };
            switch (index)
            {
                case 1:
                    tags= new List<string> { "id", "Клиент", "Лечащий врач", "Дата прихода", "Диагноз", "Лечение", "Отдых" };
                    break;
                case 2:
                    tags = new List<string> { "id", "Имя", "Фамилия", "Номер телефона", "Возраст"};
                    break;
                case 3:
                    tags = new List<string> { "id", "Диагноз"};
                    break;
                case 4:
                    tags = new List<string> { "id", "Имя", "Фамилия", "Должность", "Кабинет", "Логин и пароль"};
                    break;
                case 5:
                    tags = new List<string> { "id", "Логин", "Пароль", "Роль" };    
                    break;
                case 6:
                    tags = new List<string> { "id", "Должность"};
                    break;
                case 7:
                    tags = new List<string> { "id", "Роль"};
                    break;
                case 8:
                    tags = new List<string> { "id", "Должность"};
                    break;
            }
            string[] tagsstring = tags.ToArray();
            searchPole.Items.AddRange(tagsstring);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index= tabControl1.SelectedIndex+1;
            
            switch (index)
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
            }
            
            CreateColumns(dgw, index);
            RefresDataGrid( dgw, index);
            searchtags(index);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex +1;
            int id = Convert.ToInt32(dgw[0,dgw.CurrentRow.Index].Value.ToString());           
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите удалить запись?",
                "Удаление записи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
            {
                deleteRow(index,id);
                RefresDataGrid( dgw, index);
            }

            this.TopMost = true;
        }
        private void deleteRow(int index, int id)
        {
            

            switch (index)
            {
                case 1:
                    queryString = $"delete from workers where(idjornal = " +id+")";
                    break;
                case 2:
                    queryString = $"delete from workers where(id = " + id + ")";
                    break;
                case 3:
                    queryString = $"delete from workers where(iddiaonoz = " + id + ")";
                    break;
                case 4:
                    queryString = $"delete from workers where(idworker = " + id + ")";
                    break;
                case 5:
                    queryString = $"delete from workers where(idaccounts = " + id + ")";
                    break;
                case 6:
                    queryString = $"delete from workers where(idrang = " + id + ")";
                    break;
                case 7:
                    queryString = $"delete from workers where(idrols = " + id + ")";
                    break;
                case 8:
                    queryString = $"delete from workers where(number = " + id + ")";
                    break;
            }
            SqlCommand command = new SqlCommand(
                queryString, dataBase.getConnection());
            command.ExecuteNonQuery();
        }
    }
}
