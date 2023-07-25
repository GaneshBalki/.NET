// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using BOL;
using DAL;


IDBManager dbm=new DBManager();

bool status=true;
// Console based Menu driven User Interface
while(status)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  Books");
    Console.WriteLine("2. Insert  Book");
    Console.WriteLine("3. Update existBook");
    Console.WriteLine("4. Delete existBook");
    Console.WriteLine("5. Exit");

    switch(int.Parse(Console.ReadLine()))
    {
        //Display Departments
        case 1:
        {
            List<Book> allBooks=dbm.GetAll();

            foreach (var dept in allBooks)
            {
                Console.WriteLine(" Id: {0}, Name: {1}, Price: {2}",
                                    dept.Id,dept.Name,dept.Price);
            }
        }
        break;
            
        //Insert new  Department
        case 2:
            var newBook = new Book()
            {
                Id = 23,
                Name = "Hear YourSelf",
                Price = 230
                
            };
            dbm.Insert(newBook);
        break;

        // Update existing Department
        case 3:
        {
            var updateBook = new Book(){
                Id = 23,
                Name = "IKIGAI",
                 Price = 230
            };
            dbm.Update(updateBook);
        }
        break;
    
        // Delete existing Book
        case 4:
            dbm.Delete(23);
        break;
    
        //Exit from loop
        case 5:
            status = false;
        break;
    }
}



