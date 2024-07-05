using System.Data;
using System.Data.SqlClient;
using W8_ITE5230_Lab8_Inclass.Entity;

namespace W8_ITE5230_Lab8_Inclass.Database
{
    class StateDB
    {
        public static List<State> LoadStates()
        {
            SqlConnection conn = MMABooksDB.GetConnection();
            string query = "select * from states";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                List<State> result = new List<State>();
                while (reader.Read())
                {
                    State state = new State();
                    state.StateCode = (string)reader["StateCode"];
                    state.StateName = (string)reader["StateName"];
                    result.Add(state);
                }
                reader.Close();
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
