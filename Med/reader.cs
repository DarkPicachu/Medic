using Med.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Med
{
    internal class reader
    {
        DataBase dataBase = new DataBase();
        string querystring = "";
        public void read(string select,string from ,string index,string item, out string[]items)
        {
            List<string> strings= new List<string>();            
            querystring = $"select {select} " +
                $"from {from} " +
                $"where {index} like '%{item}%'";

            SqlCommand cmd = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                strings.Add(reader.GetString(0));                
            }
            items = strings.ToArray();
            reader.Close();
           //45
        }


    }
}
