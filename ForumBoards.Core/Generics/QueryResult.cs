using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.Core.Generics
{
    public class QueryResult<T>
    {
        public bool Successful { get; }
        public IEnumerable<string> Messages { get; }
        public T? Result { get; set; }

        public QueryResult(bool successful, IEnumerable<string> messages)
        {
            Successful = successful;
            Messages = messages;
        }

        public QueryResult(bool successful, T? result)
        {
            Successful = successful;
            Result = result;
        }
    }
}
