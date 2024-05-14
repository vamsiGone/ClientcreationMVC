using ClientCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientCreation.Data
{
    public class RegistrationDbContext:DbContext
    {
        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options)
        {
           
        }
        public DbSet<TypeLookUpMaster> TypeLookUpMaster { get; set; }
        public DbSet<RegistrationCheckList> RegistrationCheckList { get; set; }
    }
}
