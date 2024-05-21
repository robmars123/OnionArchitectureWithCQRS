using ForumBoards.Core.Abstraction;

namespace ForumBoards.QueryHandlers.Models.Abstraction
{
    public interface IHandleQuery<in TQuery, out TReturn> where TQuery : IQuery<TReturn>
    {
        TReturn Handle(TQuery query);
    }
}
