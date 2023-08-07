using Hectre.HarvestManagement.WebAPI.Models;

namespace Hectre.HarvestManagement.Authantication
{
    public class MockUserRepository : IUserRepository
    {
        private IList<User> _users = new List<User>
        {
            new User
            {
                Id = 1, Username = "admin", Password = "admin"
            }
        };
        public  Task<bool> Authenticate(string username, string password)
        {
            if (_users.SingleOrDefault(x => x.Username == username && x.Password == password) != null)
            {
                return Task.FromResult<bool>(true);
            }
            return Task.FromResult<bool>(false);
        }

    }
}

