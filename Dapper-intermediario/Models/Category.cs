using System;
using Dapper.Contrib.Extensions;

namespace Dapper_intermediario.Models
{
    [Table("Category")]
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }
    }
}