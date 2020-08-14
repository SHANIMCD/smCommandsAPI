using System.Collections.Generic;
using smCommander.Models;

namespace smCommander.Data

{
    public interface IsmCommanderRepo
    {
        IEnumerable<Command> getAllCommands();
        Command GetCommandById(int id);
    }
}