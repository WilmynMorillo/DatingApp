using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.DATA
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext _context)
        {
            this._context = context;

        }
        public Task<User> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            bye[] passwordHash, passwordSalt;
            CreatePasswordHash(password, passwordHash, passwordSalt)
        }

        public Task<User> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}