﻿using Application.Services.Write.Books;
using MediatR;

namespace Application.Repositories.Command.Books.Delete
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IWriteBookService _writeBookService;

        public DeleteBookCommandHandler(IWriteBookService writeBookService)
        {
            _writeBookService = writeBookService;
        }

        public async Task Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            await _writeBookService.DeleteBookAsync(request.Id);
        }

    }
}
