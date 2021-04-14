using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
/**
 * ALLOWS TO CONNECT TO DIFFERENT TYPE OF DATA SOURCES USING 
 * 
 */
namespace CWK2
{
    public static class DB
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["CalendarDB"].ConnectionString;
        //private static string connectionString = ConfigurationManager.ConnectionStrings["Data Source = (LocalDB)/MSSQLLocalDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"].ConnectionString;

        public static SqlConnection connection = new SqlConnection(connectionString);

        //additional method
        private static StringBuilder builder = new StringBuilder();


        //get connection string
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static void connect()
        {
            try
            {
                connection.Open(); 
                builder.Append("Opened Connection to " + connection.ConnectionString);            
                // Close the connection explicitly
                connection.Close(); 
                builder.Append("Closed connection. It is important to close connections explicitly.");
            }
            catch
            {
                builder.Append("Couldn't Open Connection to " + connection.ConnectionString);
            }
            System.Diagnostics.Debug.WriteLine(builder);

        }
        public static bool insertCont(Model.Contact contact)
        {
            bool status = false;
            try
            {

                // string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";
                //SqlCommand cmd = new SqlCommand(sql, conn);




               //  SqlCommand command = new SqlCommand("INSERT INTO Contact(FirstName, LastName, MobileNum, Email, Address, Notes, DateOfBirth) VALUES(@FirstName, @LastName, @MobileNum, @Email, @Address, @Notes, @DateOfBirth)", connection);
               //// SqlCommand command = new SqlCommand("INSERT INTO Contact(FirstName, LastName , MobileNum = @MobileNum, Email = @Email, Address = @Address, Notes = @Notes, DateOfBirth = @DateOfBirth)VALUES(@FirstName, @LastName, @MobileNum, @Email, @Address, @Notes, @DateOfBirth)", connection);
              

                connection.Open();
                builder.Append("Opened Connection to " + connection.ConnectionString);
                // Execute query

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "Insert_Contact";
                command.Connection = connection;

                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@MobileNum", contact.MobileNum);
                command.Parameters.AddWithValue("@Email", contact.Email);
                command.Parameters.AddWithValue("@Address", contact.Address);
                command.Parameters.AddWithValue("@Notes", contact.Notes);
                command.Parameters.AddWithValue("@DateOfBirth", contact.DateOfBirth);
              //  command.Parameters.AddWithValue("@ContactId", contact.ContactId);


                //using (SqlDataReader rdr = cmd.ExecuteReader())
                //{
                //    // iterate through results, printing each to console
                //    while (rdr.Read())
                //    {
                //        Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["ProductName"], rdr["Total"]);
                //    }
                //}

                command.ExecuteNonQuery();
                builder.Append("\nNew Record inserted into Contact table.");
                status = true;


            }
            catch (Exception e)
            {
                builder.Append("\nCouldn't insert record: " + e.ToString());
            }
            finally
            {
                connection.Close();
                builder.Append("\nConnection closed");
            }
            return status;

        }
        public static bool insert(string table, string attributes, string values)
        {
            bool status = false;
            //SqlCommand mySqlCommand = new SqlCommand("INSERT INTO " + table + "(CustomerId, CompanyName, ContactName, ContactTitle, Address) Values('ABC','ABC Company', 'John Smith','Owner',’Message')", connection);
            
            try
            {
                SqlCommand mySqlCommand = new SqlCommand("INSERT INTO " + table + "(" + attributes + ") Values(" + values + ")", connection);
            //    mySqlCommand.Parameters.AddWithValue("@FirstName", username);
                //mySqlCommand.Parameters.AddWithValue("Password", password);

                connection.Open();
                builder.Append("Opened Connection to " + connection.ConnectionString);
                // Execute query
                mySqlCommand.ExecuteNonQuery();
                builder.Append("\nNew Record inserted into Contact table.");
                status = true; 
            }
            catch (Exception e)
            {
                builder.Append("\nCouldn't insert record: " + e.ToString());
            }
            finally
            { 
                connection.Close();
                builder.Append("\nConnection closed");
            }

            System.Diagnostics.Debug.WriteLine(builder);
            return status; 
        }




        //public static void Connect()
        //{
        //    //connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CWK2.Properties.Settings.CalendarConnectionString"].ConnectionString);
        //    connection = new SqlConnection(connectionString);
        //}
    }
}


        //load all data from entity and return in data
        //  public void loadAllData(string entity)
        //{


        //}
        //public void connect()
        //{
        //    connection.Open();
        //}
        //public void close()
        //{
        //    connection.Close();
        //}
    /*    public SqlConnection connection()
        {
            return connection; 
        }
*/


   // }
//}
