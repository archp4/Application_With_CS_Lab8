using System.Data;
using System.Data.SqlClient;
using W8_ITE5230_Lab8_Inclass.Entity;

namespace W8_ITE5230_Lab8_Inclass.Database
{
    class CustomerDB
    {
        public static DataTable LoadCustomer()
        {
            SqlConnection conn = MMABooksDB.GetConnection();
            string query = "select * from Customers";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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

        public static Customer? GetCustomer(int customerId)
        {

            SqlConnection conn = MMABooksDB.GetConnection();
            string query = "select * from Customers where CustomerID = @CustomerID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            try
            {
                conn.Open();
                SqlDataReader result = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (result.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = (int)result["CustomerID"];
                    customer.Name = (string)result["Name"];
                    customer.Address = (string)result["address"];
                    customer.State = (string)result["State"];
                    customer.City = (string)result["City"];
                    customer.ZipCode = (string)result["ZipCode"];
                    return customer;
                }
                else
                {
                    return null;
                }
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


        public static bool UpdateCustomer(Customer newCustomer, Customer oldCustomer)
        {

            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement = "UPDATE Customers SET Name = @NewName, Address = @NewAddress, City = @NewCity, State = @NewState, ZipCode = @NewZipCode " +
                                        "WHERE Name = @OldName AND Address = @OldAddress AND City = @OldCity AND State = @OldState AND ZipCode = @OldZipCode";


            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewName", newCustomer.Name);
            updateCommand.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            updateCommand.Parameters.AddWithValue("@NewCity", newCustomer.City);
            updateCommand.Parameters.AddWithValue("@NewState", newCustomer.State);
            updateCommand.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);
            updateCommand.Parameters.AddWithValue("@OldName", oldCustomer.Name);
            updateCommand.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
            updateCommand.Parameters.AddWithValue("@OldCity", oldCustomer.City);
            updateCommand.Parameters.AddWithValue("@OldState", oldCustomer.State);
            updateCommand.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {

                connection.Close();
            }

        }


        public static int AddCustomer(Customer customer)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertQuery = "INSERT INTO Customers " +
                                 "(Name, Address, City, State, ZipCode) " +
                                 "Values (@Name, @Address, @City, @State, @ZipCode)";

            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@Name", customer.Name);
            insertCommand.Parameters.AddWithValue("@Address", customer.Address);
            insertCommand.Parameters.AddWithValue("@City", customer.City);
            insertCommand.Parameters.AddWithValue("@State", customer.State);
            insertCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode.ToCharArray());

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT('Customers') FROM Customers";
                SqlCommand selectQuery = new SqlCommand(selectStatement, connection);
                int customerID = Convert.ToInt32(selectQuery.ExecuteScalar());
                return customerID;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

        }


        public static bool DeleteCustomer(Customer customer)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteQuery = "DELETE FROM Customers " +
                                 "WHERE Name = @Name AND Address = @Address AND City = @City AND State = @State AND ZipCode = @ZipCode";

            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@Name", customer.Name);
            deleteCommand.Parameters.AddWithValue("@Address", customer.Address);
            deleteCommand.Parameters.AddWithValue("@City", customer.City);
            deleteCommand.Parameters.AddWithValue("@State", customer.State);
            deleteCommand.Parameters.AddWithValue("@ZipCode", customer.ZipCode);

            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }




        }
    }
}
