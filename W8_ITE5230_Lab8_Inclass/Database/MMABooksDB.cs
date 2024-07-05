using System.Data.SqlClient;

namespace W8_ITE5230_Lab8_Inclass.Database
{
    class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=Ninja-LOQ\\SQLEXPRESS01;Initial Catalog=MMABooks;Integrated Security=True;";

            // If using App.Config
            // string connectionString = ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
