namespace CRT;
using System.Collections.Generic;
public class Cart
{

    List<Product> plist = new List<Product>();
    public Cart()
    {
        plist.Add(new Product { Pid = 11, Pname = "Lux", Price = 12 });
        plist.Add(new Product { Pid = 12, Pname = "Shampoo", Price = 1 });
        plist.Add(new Product { Pid = 13, Pname = "Godrej", Price = 200 });
        plist.Add(new Product { Pid = 14, Pname = "Santoor", Price = 20 });
    }
    public Product this[int index]{
        get{return this.plist[index];}
        set{this.plist[index]=value;}
    }

}