using System;
using System.Collections.Generic;

namespace BookApi.Entities
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public int? Price { get; set; }
        public string Author { get; set; } = null!;
        public string? Lang { get; set; }
        public string? Publisher { get; set; }
    }
}
