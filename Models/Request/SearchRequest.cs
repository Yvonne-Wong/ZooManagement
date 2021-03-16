namespace ZooManagement.Models.Request
{
    public class SearchRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public virtual string Filters => "";
    }

    public class AnimalSearchRequest : SearchRequest
    {
        private string _search;

        public string Search
        {
            get => _search?.ToLower();
            set => _search = value;
        }

        public override string Filters => Search == null ? "" : $"&search={Search}";

        
    }
}