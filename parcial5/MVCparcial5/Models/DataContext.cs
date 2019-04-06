using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCparcial5.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")

        {
            
        }

        public System.Data.Entity.DbSet<MVCparcial5.Models.Friend> Friends { get; set; }
    }
}