using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions options):base(options)
            {}
        public DbSet<Transaction> Transactions { get; set; }    
        public DbSet<Category> Categories { get; set; }
    }
}
