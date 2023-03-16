using System.Data.SqlClient;

namespace Med
{
    class DataBase
    {

            SqlConnection con = new SqlConnection(@"Data Source=kab210comp02\ELITASQL;Initial Catalog=hospital;Integrated Security=True");

            public void openConnection()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }


            public void closeConnection()
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }


            public SqlConnection getConnection()
            {
                return con;
            }
    }
}