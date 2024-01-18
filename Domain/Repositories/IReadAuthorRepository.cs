using Domain.Entities;

namespace Domain.Repositories
{
    public interface IReadAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthorsAsync();

        Task<Author> GetAuthorByIdAsync(int id);

        Task<IEnumerable<Book>> GetBooksOfAuthorByIdAsync(int id);

    }
}
