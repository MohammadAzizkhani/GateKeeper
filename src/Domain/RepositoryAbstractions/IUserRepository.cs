using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Domain.RepositoryAbstractions
{
    public interface IUserRepository
    {
        Task CreateUser(User user);
        Task<bool> IsUserAuthenticated(User user);
    }
}
