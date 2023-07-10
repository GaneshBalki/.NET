using PRSN;
namespace STD;

public class Student:Person{
    private string course;
    private string city;
    private int duration;
 

    public Student(string fName,string lName,int age,DateTime bDate,string course,string city,int dur):base(fName,lName,age,bDate){
        
        this.course=course;
        this.city=city;
        this.duration=dur;
       
    }

    public string Course{
        get{return this.course;}
        set{this.course=value;}
    }
    public override string ToString()
{
    return $"Name: {base.FName} {base.LName}\nAge: {base.Age}\nBirth Date: {base.Bdate}\nCourse: {course}\nCity: {city}\nDuration: {duration}";
}

}