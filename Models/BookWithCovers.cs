using System.Collections.Generic;

namespace Books.Api.Models
{
    public class BookWithCovers
    {
         public IEnumerable<BookCover> BookCovers { get; set; } = new List<BookCover>();
    }
}