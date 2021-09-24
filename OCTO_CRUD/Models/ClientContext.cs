using Microsoft.EntityFrameworkCore;

namespace OCTO_CRUD.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
