namespace Artitest.Models;
using Microsoft.Data.SqlClient;
public class ArtitestDAL
{
     string connectionstring =
        "Server=localhost,1433;Initial Catalog=IACSDDB;User Id=sa;Password=Akshay123#;TrustServerCertificate=True;";

     public List<Artitest> getAllArtitests()
     {
         List<Artitest> artitests = new List<Artitest>();
         
        SqlConnection connection=new SqlConnection(connectionstring);
        connection.Open();
        SqlCommand commandd = new SqlCommand("select * from Aritest", connection);
        SqlDataReader reader = commandd.ExecuteReader();
        while (reader.Read())
        {
            Artitest aritest = new Artitest();
            aritest.Aid=Convert.ToInt32(reader["Aid"]);
            aritest.Name = reader["Name"].ToString();
            aritest.Email = reader["Email"].ToString();
            aritest.Contact = reader["Contact"].ToString();
            aritest.Skilldescription = reader["Skilldescription"].ToString();
            artitests.Add(aritest);
        }
         connection.Close();
         return artitests;
     }

     public Artitest getArtiest(int id)
     {
         List<Artitest> aritiest= getAllArtitests();

         Artitest singleAritest = (from Aritest in aritiest
             where Aritest.Aid == id
             select Aritest).First();
         return singleAritest;

     }
     
     //add
     public int addArtitest(Artitest artitest)
     {
         SqlConnection connection=new SqlConnection(connectionstring);
         connection.Open();

         string queryformat =
             "insert into Aritest(Name , Email , Contact ,Skilldescription) values('{0}','{1}','{2}','{3}')";
         string query = string.Format(queryformat, artitest.Name, artitest.Email, artitest.Contact,
             artitest.Skilldescription);
         SqlCommand commad = new SqlCommand(query,connection);

         int rowsaffected = commad.ExecuteNonQuery();
         connection.Close();
         return rowsaffected;

     }
     
     //update
     public int UpdateArtitest(Artitest artitest)
     {
         SqlConnection connection=new SqlConnection(connectionstring);
         connection.Open();

         string queryformat =
             "update Aritest set Name='{0}' , Email='{1}' , Contact='{2}' ,Skilldescription='{3}' where Aid={4}";
         string query = string.Format(queryformat, 
             artitest.Name, artitest.Email, artitest.Contact,
             artitest.Skilldescription ,artitest.Aid);
         SqlCommand commad = new SqlCommand(query,connection);

         int rowsaffected = commad.ExecuteNonQuery();
         connection.Close();
         return rowsaffected;

     }
     
     //delete
     public int DeleteArtitest(int Aid)
     {
         SqlConnection connection=new SqlConnection(connectionstring);
         connection.Open();

         string queryformat = "delete from Aritest where Aid={0}";
         string query = string.Format(queryformat ,Aid);
         SqlCommand commad = new SqlCommand(query,connection);

         int rowsaffected = commad.ExecuteNonQuery();
         connection.Close();
         return rowsaffected;

     }

}