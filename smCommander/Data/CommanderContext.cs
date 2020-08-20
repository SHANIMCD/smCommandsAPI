using Microsoft.EntityFrameworkCore;
using smCommander.Models;

namespace smCommander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands {get; set; }
    }
}