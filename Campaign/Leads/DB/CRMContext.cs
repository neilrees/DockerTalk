using System.Data.Entity;

namespace Leads.DB
{
    public class CRMContext : DbContext
    {
        public DbSet<Lead> Leads { get; set; }
    }
}