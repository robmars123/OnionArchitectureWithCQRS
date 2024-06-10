namespace ForumBoards.APIClient.API.Models
{
    public class ListModel<T>
    {   /// <summary>
        /// The count of items returned by the request
        /// </summary>
        public int Count => Results?.Count ?? 0;
        /// <summary>
        /// The collection of items requested by the API client
        /// </summary>
        private IList<T> _results;
        public IList<T> Results
        {
            get => _results ?? (_results = new List<T>());
            set => _results = value;
        }

        public ListModel()
            :this(new List<T>())
        {  }

        public ListModel(List<T> results)
        {
            _results = results ?? new List<T>();
        }
        public ListModel(IEnumerable<T> results)
            : this(results?.ToList() ?? new List<T>()) { }
    }
}
