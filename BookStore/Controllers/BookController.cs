﻿using Application.Repositories.Command.Books.Create;
using Application.Repositories.Command.Books.Delete;
using Application.Repositories.Command.Books.Update;
using Application.Repositories.Query.Books;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly ISender _mediator;

        public BookController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _mediator.Send(new GetAllBooksQuery());

            return Ok(books);
        }

        [HttpGet("GetBook/{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var query = new GetBookByIdQuery(id);

            var book = await _mediator.Send(query);

            return Ok(book);

        }

        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateBook(CreateBookCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpDelete("DeleteBook/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var deleteCommand = new DeleteBookCommand(id);
            await _mediator.Send(deleteCommand);
            
            return Ok();
        }

        [HttpPut("UpdateBook/{id}")]
        public async Task<IActionResult> UpdateBook(int id, UpdateBookCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await _mediator.Send(command);

            return Ok();
        }

    }
}
