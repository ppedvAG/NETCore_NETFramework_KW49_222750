using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Neueres Packages gegenüber -> System.Data.SqlClient
using Microsoft.Data.SqlClient;

namespace ADONET_WithNET7
{
    public class Microsoft_Data_SqlClient
    {
        public void Sample()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=WebAPI_NET7_withControllers.Data;Trusted_Connection=True;");
            DataTable resultTable = new();

            try
            {
                sqlConnection.OpenAsync();
                string sqlQuery = "SELECT * FROM Movies;";
                
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(resultTable);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void Sample_DataReader()
        {

            SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=WebAPI_NET7_withControllers.Data;Trusted_Connection=True;");
            SqlDataReader reader;

            try
            {
                //Öffnen der Connection 
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Movies;", sqlConnection);

                //SqlCommand wird ausgeführt. Das Ergebnis wir im SqlDataReader sequentiell angeboten
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                            reader.GetString(1));
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
