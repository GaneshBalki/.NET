namespace Exam;
using Question;
public class Exam
{
  private String examDate;
  private int duration;
  private Question[] examSet;

public Exam(string ed,int dr,Question[] qar){
    this.examDate=ed;
    this.duration=dr;
    this.examSet=qar;
}
  public string ExamDate{
    get{return this.examDate;}
    set{this.examDate=value;}
  }
  public int Duration{
    get{return this.duration;}
    set{this.duration=value;}
  }
  /* public Question ExamSet{
    get{return this.examSet;}
    set{this.examSet=value;}
  } */
}
