using Models;

namespace FileData
{
    public interface IUserService
    {
        User ValidateUser(string UserName, string Password);
    }
}