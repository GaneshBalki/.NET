namespace ExamService;
using Exam;
using Question;
public class ExamSer
{
    static Question [] java=new Question[3];
    static Question [] dotnet=new Question[3];
   static ExamSer(){
          string [] op1={"james G","Adams","Smith","Denis"};
          java[0]=new Question("Founder of Java?",op1,"James G",4);
          string [] op2={"Java Developement kit","Java Deployement kit","java Developer kit"};
          java[1]=new Question("Full Form Of JDK",op2,"Java Developement kit",4);
          string [] op3={"sqrt(4)","math.sqrt(4)","Math.sqrt(4)"};
          java[2]=new Question("Find Squaroot of 4",op3,"Math.sqrt(4)",4);
          
    }
      
     static Exam javaExam=new Exam("2023-07=14",2,java);
     static Exam dotNetExam=new Exam("2023-07=14",2,java);
    public static void StartExam(int choice){
    Exam choiceExam=choice==1?javaExam:dotNetExam;
       int totalMarks=0;
       
       Console.WriteLine("Exam Name");

       bool reExam=false;
       do{
        totalMarks=0;
        for(int i=0;i<java.Length;i++){
            Console.WriteLine(java[i].Que);
            for(int j=0;j<java[i].Option.Length;j++){
                Console.WriteLine(java[i].Option[j]);
            }
            Console.WriteLine("Select Answer:");
            string ans=Console.ReadLine();
            Console.WriteLine();
            if(java[i].Ans.Equals(ans,System.StringComparison.InvariantCultureIgnoreCase)){
                totalMarks=totalMarks+java[i].Marks;
            }

        }
        if(totalMarks>4){
              Console.WriteLine("You Passed the Exam. \nMarks :"+ totalMarks);
        }else{
            Console.WriteLine("Better luck next time..");
        }
         Console.WriteLine("Want to Try Again? [ Y / N ] :");
          string reExamChoice=Console.ReadLine();
           if(reExamChoice.Equals("y",System.StringComparison.InvariantCultureIgnoreCase)){
               reExam=true;
            }else{
                      Console.WriteLine("Thank You For Visiting Us !!!");
                      reExam=false;
            }
       }while(reExam);
    }
}
