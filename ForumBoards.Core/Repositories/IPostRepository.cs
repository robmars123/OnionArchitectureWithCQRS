using ForumBoards.Core.Models;
using ForumBoards.Core.Results;

namespace ForumBoards.Core.Repositories
{
    public interface IPostRepository
    {
        List<PostRequestResult> GetPosts();
    }
}