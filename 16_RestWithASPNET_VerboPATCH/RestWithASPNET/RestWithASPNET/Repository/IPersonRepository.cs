using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
    }
}
