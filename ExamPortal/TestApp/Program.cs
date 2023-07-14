// See https://aka.ms/new-console-template for more information
using ExamService;
Console.WriteLine("Exam Portal");

Console.WriteLine("Select Exam :");
Console.WriteLine("1. JAVA\n2. .NET");
int choice=Convert.ToInt32(Console.ReadLine());
ExamSer es=new ExamSer();
ExamSer.StartExam(choice);
