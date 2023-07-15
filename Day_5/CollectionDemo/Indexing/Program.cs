// See https://aka.ms/new-console-template for more information
using CRT;
Cart cart=new Cart();
Product p1=cart[1];
Console.WriteLine(p1);

cart[1]=new Product { Pid = 12, Pname = "COnditioner", Price = 100 };
Product p2=cart[1];
Console.WriteLine(p2);

Object ob=cart[2];
Console.WriteLine(ob);
Product p3=(Product)ob;