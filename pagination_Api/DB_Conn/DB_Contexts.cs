using Microsoft.EntityFrameworkCore;
using pagination_Api.DB_Model;

namespace pagination_Api.DB_Conn
{
    public class DB_Contexts: DbContext
    {
         public DB_Contexts(DbContextOptions options):base(options)
         {

         }
         
        public DbSet<EmpInfo> Empinfos { get; set; }

    }
}
