using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {

        }

        public Commander GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}