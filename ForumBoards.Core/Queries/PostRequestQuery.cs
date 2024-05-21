using ForumBoards.Core.Abstraction;
using ForumBoards.Core.Generics;
using ForumBoards.Core.Results;

namespace ForumBoards.Core.Queries
{
    public class PostRequestQuery : IQuery<QueryResult<IEnumerable<PostRequestResult>>>
    {
        public PostRequestQuery(int? id)
        {
            Id = id;
        }
        public int? Id { get; set; }
    }
}
