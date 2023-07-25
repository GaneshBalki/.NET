namespace DAL;
using BOL;
//CRUD Operations code against database inside DBManager
public class DBManager:IDBManager{
    public void Delete(int id)
    {
        using(var context = new CollectionContext())
        {
            context.Books.Remove(context.Books.Find(id));
            context.SaveChanges();
        }
    }

    public List<Book> GetAll()
    {   //Deterministic Finalization
        using (var context = new CollectionContext())
        {
            //LINQ
            var books=from book in context.Books select book;
            return books.ToList<Book>();
        }
    }

    public Book GetById(int id)
    {
        using (var context = new CollectionContext())
        {
            var book = context.Books.Find(id);
            return book;
        }
    }

    public void Insert(Book book)
    {
        using (var context = new CollectionContext())
        {
            context.Books.Add(book);
            context.SaveChanges();  
        }
    }
    public void Update(Book book)
    {
        using (var context = new CollectionContext())
        {
            var theBook = context.Books.Find(book.Id);
            theBook.Name =book.Name;
            theBook.Price=book.Price;
            context.SaveChanges();
        }
    }
}