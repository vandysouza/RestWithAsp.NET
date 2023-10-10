using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User RefreshUserInfo(User user);
    }
}
