using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
namespace Repositories.EFCore
{
    public class RepositoryContext :DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<RentStock> RentStocks { get; set; }
        //EFCORE konuları ile devam edilecek 
    }
}
