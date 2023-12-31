using MediatR;

namespace Application.Repositories.Command.Customers.Update.Buy
{
    public record BuyBookForCustomerCommand(int CustomerId, int BookId) : IRequest
    {
    }
}
