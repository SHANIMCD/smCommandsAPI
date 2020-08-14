using System.Collections.Generic;
using smCommander.Models;

namespace smCommander.Data
{
public class MockCommanderRepo : IsmCommanderRepo
{
    public IEnumerable<Command> getAllCommands()
    {
        var commands = new List<Command>
        {
            new Command{Id=0, HowTo="make toast", Line="bread in toaster", Platform="toaster and plate"},
            new Command{Id=1, HowTo="boil rice", Line="rice and pan", Platform="stove"},
            new Command{Id=2, HowTo="make tea", Line="mug and teabag", Platform="kettle"}
        };
        return commands;
    }

    public Command GetCommandById(int id)
    {
       return new Command{Id=0, HowTo="make toast", Line="bread in toaster", Platform="toaster and plate"};
    }
}
}