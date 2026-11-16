using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApi.Database
{
    public class AuthContext : IdentityDbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {

        }
    }
}
