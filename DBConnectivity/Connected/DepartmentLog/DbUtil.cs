namespace TestDB;
using HR;
using System.Collections;
using MySql.Data.MySqlClient;
public class DbUtil
{
    public static string conString = @"server=192.168.10.150;port=3306;user=dac32; password=welcome;database=dac32";

    public static List<Department> GetAllDept()
    {
        List<Department> dlist = new List<Department>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = conString;
        try
        {
           
            String query = "Select * from Departments";
            String query1 = "Select * from Departments where id=2";  
            MySqlCommand cmd = new MySqlCommand(query,conn);
           // cmd.CommandText = query;
           // cmd.Connection = conn;
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string dname = reader["name"].ToString();
                string loc = reader["location"].ToString();
                Department d1 = new Department { Id = id, Name = dname, Location = loc };
                dlist.Add(d1);
               // dlist.Add(d1);
            }


        }
        catch (Exception e)
        {

            throw e;
        }
        finally
        {
            conn.Close();
        }

        return dlist;


    }
    public static Department GetDeptById(int id){
        Department dept = null;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "SELECT * FROM departments WHERE id=" + id;
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string location = reader["location"].ToString();
                dept = new Department
                {
                    Id = id,
                    Name = name,
                    Location = location
                };
            }

        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return dept;
    }

    
 public static bool Insert(Department dept){
        bool status=false;
        string query = "INSERT INTO departments(id,name,location)" +
                            "VALUES("+dept.Id+","+"'" + dept.Name + "','" + dept.Location + "')";

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();  //DML
            status = true;
        } 
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }               
        return status;
     }
    public static bool Update(Department dept)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try
        {
            string query = "UPDATE departments SET location='" + dept.Location + "', name='" + dept.Name + "' WHERE id=" + dept.Id;
            MySqlCommand command = new MySqlCommand(query, con);
            con.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }
        return status;
    }
}