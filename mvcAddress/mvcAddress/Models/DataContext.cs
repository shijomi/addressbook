using System.Data.Entity;

namespace mvcAddress.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        
    }
}