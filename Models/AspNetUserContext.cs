using Microsoft.EntityFrameworkCore;
namespace bancomat.app.Models
{
    public class AspNetUserContext : DbContext
    {
       public DbSet<AspNetUserModel> userDetails { get; set; }
    }
}
