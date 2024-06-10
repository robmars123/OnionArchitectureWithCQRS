using ForumBoards.APIClient.API.Models;

namespace ForumBoards.Core.Models.Abstraction
{
    public interface IModelFactory<TModel, TData>
    {
        ListModel<TModel> Create(IEnumerable<TData>? models); 
        TModel Create(TData? data);
    }
}
