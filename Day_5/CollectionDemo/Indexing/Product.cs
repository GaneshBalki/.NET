namespace CRT;

public class Product
{
     public int Pid {get;set;}
     public string Pname {get;set;}
     
     public double Price {get;set;}


    public override string ToString()
    {
        return base.ToString()+"[ PID : "+this.Pid+", PNAME : "+this.Pname+", Price : "+this.Price+" ]";
    }

     
}
