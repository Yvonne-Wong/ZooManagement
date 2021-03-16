using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;

namespace ZooManagement.Models.Response 
{
    public class ListResponse<T>
    {
        private readonly string _path;
        private readonly string _filters;
        
        public IEnumerable<T> Items { get; }
        public int TotalNumberOfItems { get; }
        public int Page { get; }
        public int PageSize { get; }

        public string NextPage => !HasNextPage() ? null : $"/{_path}?page={Page + 1}&pageNumber={PageSize}{_filters}";

        public string PreviousPage => Page <= 1 ? null : $"/{_path}?page={Page - 1}&pageNumber={PageSize}{_filters}";

        public ListResponse(SearchRequest search, IEnumerable<T> items, int totalNumberOfItems, string path)
        {
            Items = items;
            TotalNumberOfItems = totalNumberOfItems;
            Page = search.Page;
            PageSize = search.PageSize;
            _path = path;
            _filters = search.Filters;
        }
        
        private bool HasNextPage()
        {
            return Page * PageSize < TotalNumberOfItems;
        }
    }

    public class AnimalListResponse : ListResponse<AnimalResponse>
    {
        private AnimalListResponse(SearchRequest search, IEnumerable<AnimalResponse> items, int totalNumberOfItems)
            : base(search, items, totalNumberOfItems, "animals") { }
        
        public static AnimalListResponse Create(SearchRequest search, IEnumerable<Animal> animals, int totalNumberOfItems)
        {
            var animalModels = animals.Select(animal => new AnimalResponse(animal));
            return new AnimalListResponse(search, animalModels, totalNumberOfItems);
        }
    }
}