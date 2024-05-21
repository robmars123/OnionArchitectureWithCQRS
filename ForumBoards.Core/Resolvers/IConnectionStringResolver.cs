using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.Core.Resolvers
{
    public interface IConnectionStringResolver
    {
        string Resolve();
    }
}
