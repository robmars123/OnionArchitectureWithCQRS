using ForumBoards.Core.Results;

namespace ForumBoards.DataAccess.Mapper
{
    public static class PostMapper
    {
        public static PostRequestResult Map(dynamic source)
        {
            if (source == null) return default;

            return new PostRequestResult(
                source.Id,
                source.UserId,
                source.MessageTextRaw
                );
        }
    }
}
