using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using System.Threading;
using BlogLab.Models.Account;

namespace BlogLab.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user, 
            CancellationToken cancellationToken);

        public Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername, 
            CancellationToken cancellationToken);
    }
}
