using LoginAndRegistration.Models;
using System.Security.AccessControl;

namespace LoginAndRegistration.Services
{
    public class SecurityServices
    {
        List<UserModel> knownUsers = new List<UserModel>();
        public SecurityServices()
        {
            knownUsers.Add(new UserModel {Id = 0, UserName = "root", Password = "toor"});
        }
        public bool isValid(UserModel user)
        {
            return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
