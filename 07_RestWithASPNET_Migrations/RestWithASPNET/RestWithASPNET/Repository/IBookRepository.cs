using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IBookRepository
    {
        Book Create(Book Book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book Book);
        void Delete(long id);
        public bool Exist(long id);
    }
}
