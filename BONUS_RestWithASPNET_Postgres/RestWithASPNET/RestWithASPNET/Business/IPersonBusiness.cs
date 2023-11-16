using RestWithASPNET.Data.VO;
using RestWithASPNET.Hypermedia.Utils;

namespace RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindByName(string firstName, string lastName);
        List<PersonVO> FindAll();

        PagedSearchVO<PersonVO> FindWithPagedSearch(
            string name, string sortDirection, int pageSize, int Page);
        PersonVO Update(PersonVO person);
        PersonVO Disable(long id);
        void Delete(long id);


    }
}
