namespace Hectre.HarvestManagement.Authantication
{
    public interface IUserRepository
    {
        Task<bool> Authenticate(string username, string password);
    }
}

