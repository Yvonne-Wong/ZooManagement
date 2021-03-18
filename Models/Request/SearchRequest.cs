using Microsoft.AspNetCore.Mvc;
// using ZooManagement.Models.Database;
// using ZooManagement.Models.Request;
// using ZooManagement.Models.Response;
// using ZooManagement.Repositories;
using System;
// using System.Text;

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
        private string name;
        [FromQuery(Name = "name")]
        public string Name 
        { 
            get { return name == null ? null : name.ToLower(); }
            set { name = value; }
        }

        [FromQuery(Name = "age")]
        public int? Age { get; set; }

        [FromQuery(Name = "acquired")]
        public string DateAcquired { get; set; }

        private string animalClass;
        [FromQuery(Name = "class")]
        public string Class 
        {
            get { return animalClass == null ? null : animalClass.ToLower();}
            set { animalClass = value; }
        }

        private string alias;
        [FromQuery(Name = "species")]
        public string Alias 
        { 
            get { return alias == null ? null : alias.ToLower(); }
            set { alias = value; }
        }
        public string Search => $"{Name}{Age}{DateAcquired}{Class}{Alias}";
        public override string Filters => Search == null ? "" : $"{(Name == null ? "" : $"&name={Name}")}{(Age == null ? "" : $"&age={Age}")}{(DateAcquired == null ? "" : $"&acquired={DateAcquired}")}{(Class == null ? "" : $"&class={Class}")}{(Alias == null ? "" : $"&species={Alias}")}";  
    }
}