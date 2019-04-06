using System.Data.Entity;

namespace APIparcial.Models
{

    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<APIparcial.Models.YamileOrellanaFriend> YamileOrellanaFriends { get; set; }
    }
}