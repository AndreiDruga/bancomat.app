using bancomat.app.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bancomat.app.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserBalance> Balances { get; set; }
        public virtual DbSet<AuditItem> Audits { get; set; }
        public virtual DbSet<AccountTo> Accounts { get; set; }
    }
}
