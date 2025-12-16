namespace MVCLab.Models;

using Microsoft.Data.SqlClient;
public class StudentViewModel
{
    private string stringconnection =
        "Server=localhost,1433;Initial Catalog=IACSDDB;User Id=sa;Password=Akshay123#;TrustServerCertificate=True;";

    public List<Student> GetStudents()
    {
        List<Student> students=new List<Student>();
        SqlConnection connection = new SqlConnection(stringconnection);
        connection.Open();
        SqlCommand command = new SqlCommand("select * from Student", connection);
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Student student = new Student();
            student.No=Convert.ToInt32(reader["No"]);
            student.Name=reader["Name"].ToString();
            student.Address=reader["Address"].ToString();
            student.Email=reader["Email"].ToString();
            student.Age=Convert.ToInt32(reader["Age"]);
            students.Add(student);
        }
        connection.Close();
        return students;
    }

    public Student GetStudent(int No)
    {
        List<Student> students = GetStudents();
        Student filterdStudent = (from Student in students
            where Student.No == No
            select Student).First();
        return filterdStudent;

    }

    public int AddStudent(Student student)
    {
        
        SqlConnection connecton=new SqlConnection(stringconnection);
        connecton.Open();
        string queryFormat="insert into Student (Name , Address ,Age ,Email,isEmailValidated) values ('{0}','{1}' ,{2} ,'{3}' ,'{4}')";
        
        String query = String.Format(queryFormat,student.Name,student.Address,student.Age,student.Email,student.Age , false);
        SqlCommand command=new SqlCommand(query ,  connecton);
        
        int rowsAffected=command.ExecuteNonQuery();
        connecton.Close();
        return rowsAffected;
    }
    public int UpdateStudent(Student student)
    {
        
        SqlConnection connecton=new SqlConnection(stringconnection);
        connecton.Open();
        string queryFormat="update Student  set Name='{0}' , Address='{1}' ,Age={2},Email='{3}' where No={4}";
        
        string query = string.Format(queryFormat,student.Name,student.Address,student.Age,student.Email,student.No);
        SqlCommand command=new SqlCommand(query ,  connecton);
        
        int rowsAffected=command.ExecuteNonQuery();
        connecton.Close();
        return rowsAffected;
       
    }
    
    public int DeleteStudent(int No)
    {
        
        SqlConnection connecton=new SqlConnection(stringconnection);
        connecton.Open();
        string queryFormat="delete from Student where No={0}";
        
        string query = string.Format(queryFormat,No);
        SqlCommand command=new SqlCommand(query ,  connecton);
        
        int rowsAffected=command.ExecuteNonQuery();
        connecton.Close();
        return rowsAffected;
    }
    
    
    
    
}