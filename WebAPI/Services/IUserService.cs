using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);

        IEnumerable<User> GetAll();

        User GetById(int id);
    }
}
