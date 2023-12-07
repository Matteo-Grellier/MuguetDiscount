using Microsoft.EntityFrameworkCore;

namespace command_microservices
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) :base(options) { } 

        public virtual DbSet<Command> Commands { get; set; }
    }
}