using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using System.Data;
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

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputerHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Usuarios.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));     
        }

        public User RefreshUserInfo(User user)
        {
            if (_context.Usuarios.Any(p => p.Id.Equals(user.Id))) return null;

            var result = _context.Usuarios.SingleOrDefault(p => p.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
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

        private string ComputerHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
         }
    }
}
