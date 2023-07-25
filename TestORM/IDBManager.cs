namespace DAL;
using BOL;
    public interface IDBManager{
        List<Book> GetAll();
        Book GetById(int id);
        void Insert(Book dept);
        void Update(Book dept);
        void Delete(int id);
    }
