using System.Data.Entity;

namespace MVCparcial3.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
            
        }

        public System.Data.Entity.DbSet<MVCparcial.Models.Friend> Friends { get; set; }
    }
}