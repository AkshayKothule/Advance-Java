
using Microsoft.Data.SqlClient;

namespace EndModule.Model
{
  
    public class ProductDAL
    {
        string connctionstring = "Server=localhost,1433;Initial Catalog=IACSDDB;User Id=sa;Password=Akshay123#;TrustServerCertificate=True;";

        public List<Product> getProduct()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection=new SqlConnection(connctionstring);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from  productDB" , connection);
            SqlDataReader reader = cmd.ExecuteReader();
           
            while(reader.Read()) 
            {
                    Product product = new Product();
                    product.Id=Convert.ToInt32(reader["id"]);
                    product.Name = reader["Name"].ToString();
                    product.Description = reader["Description"].ToString();
                    product.Price = (int)reader["Price"];
                    product.Qty = Convert.ToInt32(reader["Qty"]);
                    products.Add(product);

            }
                connection.Close();
            

            return products;
        }

        public Product getSingleProduct(int id)
        {
            List<Product> products = getProduct();

            Product singleProduct = (from P in products
                                     where P.Id == id
                                     select P).First();
            return singleProduct;
        }

        public int addProduct(Product product)
        {
            SqlConnection connection = new SqlConnection(connctionstring);
            connection.Open();
           
            string queryFormat = "insert into productDB (Name , Description , Price , Qty ,Available)values('{0}','{1}',{2} ,{3}, '{4}')";
            string query = string.Format(queryFormat,
                product.Name,
                product.Description,
                Convert.ToInt32(product.Price),
                Convert.ToInt32(product.Qty),
                false);
            SqlCommand cmd = new SqlCommand(query, connection);
           int rowsAffected= cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;

        }

        public int updateProduct(Product product)
        {
            SqlConnection connection = new SqlConnection(connctionstring);
            connection.Open();

            string queryFormat = "update productDB  set Name='{0}' , Description='{1}' , Price={2} , Qty={3} where Id={4}";
            string query = string.Format(queryFormat,
                product.Name,
                product.Description,
                product.Price,
                product.Qty,
                product.Id);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;


        }

        public int deleteProduct(int Id)
        {
            SqlConnection connection = new SqlConnection(connctionstring);
            connection.Open();

            string queryFormat = "delete from productDB where Id={0}";
            string query = string.Format(queryFormat , Id);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;


        }
    }
}
