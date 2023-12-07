using Whiskyfy_Api.ApplicationServices.Contracts;
using Whiskyfy_Api.Domain.Services.Contracts;

namespace Whiskyfy_Api.ApplicationServices.Implementation
{
    public class UserManagmentAppServices : IUserManagmentAppServices
    {
        private readonly IUsersDomainServices _usersDomainServices;
        public UserManagmentAppServices(IUsersDomainServices usersDomainServices)
        {
            _usersDomainServices = usersDomainServices;
        }
    }
}
