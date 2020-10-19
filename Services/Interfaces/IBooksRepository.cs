using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Api.ExternalModels;

namespace Books.Api.Services.Interfaces
{
    public interface IBooksRepository
    {
         
        IEnumerable<Entities.Book> GetBooks();
        Task<IEnumerable<Entities.Book>> GetBooksAsync();
        Task<Entities.Book> GetBookAsync(Guid id);
        Task<IEnumerable<Entities.Book>> GetBooksAsync(IEnumerable<Guid> bookIds);
        Task<BookCover> GetBookCoverAsync(string coverId);
        Task<IEnumerable<BookCover>> GetBookCoversAsync(Guid bookId);
        void AddBook(Entities.Book bookToAdd);
        Task<bool> SaveChangesAsync();
    }
}