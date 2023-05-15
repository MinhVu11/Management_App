using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SE104_Project
{
    public class SQLHandler
    {
        private static SQLHandler instance;
        private string connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable=new DataTable();
        private SQLHandler(string connectionString)
        {
            this.connectionString = connectionString;
            connection= new SqlConnection(connectionString);
        }
        public static SQLHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SQLHandler("Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=SE104;Integrated Security=True");
                }
                return instance;
            }               
            
        }
        public void ExcuteNonQuery(string query)
        {
            connection.Open();
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable GetData(string query)
        {
            connection.Open();
            adapter = new SqlDataAdapter(query,connection);
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

    }
}
