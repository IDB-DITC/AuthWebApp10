using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthWebApplication.Model
{
  public sealed class AppUser:IdentityUser<Guid>
  {
    public string? Photo { get; set; }
    public string? NID { get; set; }
  }

  public sealed class ExamDb:IdentityDbContext<AppUser,IdentityRole<Guid>,Guid>
  {
    public ExamDb(DbContextOptions<ExamDb> options):base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
  }

}
