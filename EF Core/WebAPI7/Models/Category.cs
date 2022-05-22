using System;
using System.Collections.Generic;

namespace Northwind.Models
{
    public partial class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
