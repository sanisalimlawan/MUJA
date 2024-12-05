using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace muja.Data
{
    public class MujaDbContext : IdentityDbContext
    {
        public MujaDbContext(DbContextOptions<MujaDbContext> options) : base(options)
        {
            
        }
    }
}
