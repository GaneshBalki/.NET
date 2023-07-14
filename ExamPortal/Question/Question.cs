namespace Question;

public class Question
{
    private  string que;
    private string[] option;
    private  string ans;
    private int marks;
    public Question(string que,string [] op,string ans,int marks){
        this.que=que;
        this.option=op;
        this.ans=ans;
        this.marks=marks;
    }
    public string Que
    {
        get { return this.que; }
        set { this.que = value; }
    }
    public string[] Option
    {
        get { return this.option; }
        set { this.option = value; }
    }
    public string Ans
    {
        get { return this.ans; }
        set { this.ans = value; }
    }
    public int Marks
    {
        get { return this.marks; }
        set { this.marks = value; }
    }
}
