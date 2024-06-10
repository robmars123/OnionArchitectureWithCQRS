using ForumBoards.APIClient.Models;
using ForumBoards.Core.Models;
using ForumBoards.Core.Results;
using ForumBoards.Infrastructure.Factory.Abstraction;

namespace ForumBoards.Infrastructure.Factory
{
    public class PostModelFactory : ModelFactoryBase<PostRequestModel, PostRequestResult>
    {
        public override PostRequestModel Create(PostRequestResult data)
        {
            if (data == null)
                return new PostRequestModel();

            return new PostRequestModel
            {
                Id = data.Id,
                MessageTextRaw = data.MessageTextRaw,
                UserId = data.UserId,
            };
        }
    }
}
