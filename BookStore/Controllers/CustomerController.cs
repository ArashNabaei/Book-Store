﻿using Application.Repositories.Command.Customers.Create;
using Application.Repositories.Command.Customers.Delete;
using Application.Repositories.Command.Customers.Update;
using Application.Repositories.Command.Customers.Update.Buy;
using Application.Repositories.Command.Customers.Update.Deposit;
using Application.Repositories.Query.Customers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ISender _mediator;

        public CustomerController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _mediator.Send(new GetAllCustomersQuery());

            return Ok(customers);
        }

        [HttpGet("GetCustomer/{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var query = new GetCustomerByIdQuery(id);

            var customer = await _mediator.Send(query);

            return Ok(customer);

        }

        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var deleteCommand = new DeleteCustomerCommand(id);
            await _mediator.Send(deleteCommand);

            return Ok();
        }


        [HttpPut("UpdateCustomer/{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, UpdateCustomerCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await _mediator.Send(command); 
            
            return Ok();
        }
        [HttpGet("getBooksOfCustomer/{customerId}")]
        public async Task<IActionResult> GetBooksOfCustomerById(int customerId)
        {
            var query = new GetBooksOfCustomerByIdQuery { Id = customerId };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [HttpPost("buy")]
        public async Task<IActionResult> BuyBookForCustomer(BuyBookForCustomerCommand command)
        {
            var query = new BuyBookForCustomerCommand(command.CustomerId, command.BookId);

            await _mediator.Send(query);

            return Ok(query);
        }

        [HttpPut("Deposit")]
        public async Task<IActionResult> Deposit(DepositCommand command)
        {
            var query = new DepositCommand(command.Id, command.Amount);
            await _mediator.Send(query);

            return Ok(query);
        }

    }
}
