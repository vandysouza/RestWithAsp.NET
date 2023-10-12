using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using System.Security.Cryptography;
using System.Text;

namespace RestWithASPNET.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MySQLContext _context;

        public UserRepository(MySQLContext context)
        {
            _context = context;
        }
        public User ValidateCredentials(string username)
        {
            return _context.User.SingleOrDefault(u => (u.UserName == username));
        }

        public bool RevokeToken(string username)
        {
           var user = _context.User.SingleOrDefault(u => u.UserName == username);
            if (user is null) return false;
            user.RefreshToken = null;
            _context.SaveChanges();
            return true;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.User.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.User.Any(p => p.Id.Equals(user.Id))) return null;

            var result = _context.User.SingleOrDefault(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _context.User.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return result;
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}


