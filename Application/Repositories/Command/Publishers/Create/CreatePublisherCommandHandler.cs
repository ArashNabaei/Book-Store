﻿using Application.DTOs;
using Application.Services.Write.Publishers;
using MediatR;

namespace Application.Repositories.Command.Publishers.Create
{
    public class CreatePublisherCommandHandler : IRequestHandler<CreatePublisherCommand>
    {

        private readonly IWritePublisherService _writePublisherService;

        public CreatePublisherCommandHandler(IWritePublisherService writePublisherService)
        {
            _writePublisherService = writePublisherService;
        }

        public async Task Handle(CreatePublisherCommand request, CancellationToken cancellationToken)
        {
            var newPublisher = new PublisherDTO
            {
                Name = request.Name,
                Address = request.Address,
                Information = request.Information
            };

            await _writePublisherService.CreatePublisherAsync(newPublisher);
        }
    }
}
