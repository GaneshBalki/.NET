// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using Catalog;
List<Product> list=new List<Product>();
list.Add(new Product{Pid=11,Pname="Lux", Price=12});
list.Add(new Product{Pid=12,Pname="Shampoo", Price=1});

foreach(Product p in list){
Console.WriteLine(p.Pid+" "+p.Pname+" "+p.Price);
}

Dictionary<int,Product> pDict=new Dictionary<int,Product>();
pDict.Add(13,new Product{Pid=13,Pname="Godrej", Price=200});
pDict.Add(14,new Product{Pid=14,Pname="Santoor", Price=20});
Product p1=pDict[13];
Console.WriteLine(p1.Pid+" "+p1.Pname+" "+p1.Price);

Stack<Product> pstack=new Stack<Product>();
pstack.Push(new Product{Pid=15,Pname="Keybord", Price=150});
pstack.Push(new Product{Pid=16,Pname="Mouse", Price=250});
Product p2=pstack.Peek();
Console.WriteLine(p2.Pid+" "+p2.Pname+" "+p2.Price);




