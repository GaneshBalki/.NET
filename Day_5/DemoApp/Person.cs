namespace HR;
public class Person:IDisposable{
  public Person(){}
    public string Fname{get;set;}
    public string Lname{get;set;}

    public override string ToString()
    {
        return base.ToString()+" Fname :"+Fname+", Lname :"+Lname;
    }
    public void Dispose(){
          Console.WriteLine("hello this is dispose method");
    }

    ~Person(){
Console.WriteLine("hello this is Destructor  method");
    }

}