// See https://aka.ms/new-console-template for more information
using HR;
Console.WriteLine("Before Person object is created....");

using(Person p=new Person{Fname="Virat", Lname="Kohli"}){
    Console.WriteLine(p);
}
Console.WriteLine("After person work is finished....");
GC.Collect();