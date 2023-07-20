// See https://aka.ms/new-console-template for more information
using HR;
using TestDB;
using System.Collections;
List<Department> dlist=DbUtil.GetAllDept();


foreach (Department d in dlist)
{
    Console.WriteLine("ID : {0}, Name : {1}, Location : {2}",d.Id,d.Name,d.Location);
}

Department d1=DbUtil.GetDeptById(2);
Console.WriteLine("ID : {0}, Name : {1}, Location : {2}",d1.Id,d1.Name,d1.Location);
/*
Department dept = new Department
                {
                    Id = 4,
                    Name = "HR",
                    Location = "MNGRL"
                };
if(DbUtil.Insert(dept)){
  Console.WriteLine("Added.......");
}



List<Department> dlist2=DbUtil.GetAllDept();


foreach (Department d in dlist2)
{
    Console.WriteLine("ID : {0}, Name : {1}, Location : {2}",d.Id,d.Name,d.Location);
}*/
Department dept2 = new Department
                {
                    Id = 1,
                    Name = "HEATH",
                    Location = "YTL"
                };
if(DbUtil.Update(dept2)){
  Console.WriteLine("Updated.......");
}


List<Department> dlist3=DbUtil.GetAllDept();


foreach (Department d in dlist3)
{
    Console.WriteLine("ID : {0}, Name : {1}, Location : {2}",d.Id,d.Name,d.Location);
}