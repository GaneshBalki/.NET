namespace TestDB;
using HR;
using System.Collections;
using System.Data;
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
            MySqlCommand cmd = new MySqlCommand();
            String query = "Select * from Departments";
            String query1 = "Select * from Departments where id=2";
            //cmd.CommandText = query;
             cmd.CommandText = query;
            cmd.Connection = conn;
           
           DataSet ds=new DataSet();
           MySqlDataAdapter da=new MySqlDataAdapter();
           da.SelectCommand=cmd;
           da.Fill(ds);
           DataTable dt=ds.Tables[0];
           DataRowCollection rows=dt.Rows;
           foreach(DataRow row in rows){

                int id = int.Parse(row["id"].ToString());
                string dname = row["name"].ToString();
                string loc = row["location"].ToString();
                Department d1 = new Department { Id = id, Name = dname, Location = loc };
                dlist.Add(d1);
           }
        }
        catch (Exception e)
        {

            throw e;
        }
        finally
        {
          
        }

        return dlist;


    }
}