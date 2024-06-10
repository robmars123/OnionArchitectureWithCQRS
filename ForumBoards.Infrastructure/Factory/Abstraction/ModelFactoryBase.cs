using ForumBoards.APIClient.API.Models;
using ForumBoards.Core.Models.Abstraction;

namespace ForumBoards.Infrastructure.Factory.Abstraction
{
    public abstract class ModelFactoryBase<TModel, TData> : IModelFactory<TModel, TData>
    {
        //protected readonly HttpContext? _context;

        public ModelFactoryBase()
        {
            
        }


        public ListModel<TModel> Create(IEnumerable<TData>? models)
        {
            ListModel<TModel> listModel = new ListModel<TModel>();

            if (models is null)
                models = Enumerable.Empty<TData>();

            listModel.Results = models.Select(Create).Where(data => data is not null).ToList();

            return listModel;
        }

        protected virtual void CreateCollectionHypermediaLinks(ListModel<TModel> listModel) { }

        public abstract TModel Create(TData data);
    }
}
