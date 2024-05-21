using ForumBoards.Core.Generics;
using ForumBoards.Core.Queries;
using ForumBoards.Core.Repositories;
using ForumBoards.Core.Results;
using ForumBoards.QueryHandlers.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumBoards.QueryHandlers.Models.Posts
{
    public class PostQueryHandler : IHandleQuery<PostRequestQuery, QueryResult<IEnumerable<PostRequestResult>>>
    {
        private readonly IPostRepository _postRepository;

        public PostQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public QueryResult<IEnumerable<PostRequestResult>> Handle(PostRequestQuery query)
        {
            try
            {
                IEnumerable<PostRequestResult> result = _postRepository.GetPosts(); //replace by repository
                return new QueryResult<IEnumerable<PostRequestResult>>(true, result);
            }
            catch (Exception ex)
            {
                List<string> errorMessages = new List<string> { ex .Message };
                return new QueryResult<IEnumerable<PostRequestResult>>(false, errorMessages);
            }

        }
    }
}
