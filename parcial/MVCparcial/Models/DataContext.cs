using System.Data.Entity;

namespace MVCparcial.Models
{

    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<MVCparcial.Models.YamileOrellanaFriend> YamileOrellanaFriends { get; set; }
    }
}