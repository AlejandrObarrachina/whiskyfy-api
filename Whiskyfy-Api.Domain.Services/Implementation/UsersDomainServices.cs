using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whiskyfy_Api.Domain.Services.Contracts;
using Whiskyfy_Api.Infrastructure.Repository.Contracts;

namespace Whiskyfy_Api.Domain.Services.Implementation
{
    public class UsersDomainServices : IUsersDomainServices
    {
        private readonly IUserManagmentRepository _usersRepo;
        public UsersDomainServices(IUserManagmentRepository usersRepo)
        {
            _usersRepo = usersRepo;
        }
    }
}
