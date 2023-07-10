namespace PRSN;

public class Person{
    private string fname;
    private string lname;
    private int age;
    private DateTime bDate;

    public Person(string fName,string lName,int age,DateTime bDate){
        this.fname=fName;
        this.lname=lName;
        this.age=age;
        this.bDate=bDate;
    }

    public string FName{
        get{return this.fname;}
        set{this.fname=value;}
    }
    public string LName{
        get{return this.lname;}
        set{this.lname=value;}
    }
    public int Age{
        get{return this.age;}
        set{this.age=value;}
    }
    public DateTime Bdate{
        get{return this.bDate;}
        set{this.bDate=value;}
    }
}