// See https://aka.ms/new-console-template for more information
using HR;
using TestDB;

Console.WriteLine("Hello, World!");
List<Department> dlist=DbUtil.GetAllDept();
foreach(Department d in dlist){
    Console.WriteLine("ID : {0}, Name : {1}, Location : {2}",d.Id,d.Name,d.Location);

}
