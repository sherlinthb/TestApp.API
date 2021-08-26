using Microsoft.EntityFrameworkCore;

namespace TestApp.API.Models
{
    public class ApiContext: DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options){}

        public DbSet<Info> Infos {get;set;}
        public DbSet<Tip> Tips {get;set;}
    }
}