using Application.DTOs;

namespace Application.Services.Write.Authors
{
    public interface IWriteAuthorService
    { 
        Task<int> CreateAuthorAsync(AuthorDTO authorDTO);

        Task DeleteAuthorAsync(int Id);

        Task UpdateAuthorAsync(int id, AuthorDTO authorDTO);

    }
}
