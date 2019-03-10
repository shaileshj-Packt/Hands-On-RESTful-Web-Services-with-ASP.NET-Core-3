using MediatR;
using VinylStore.Catalog.Domain.Responses.Users;

namespace VinylStore.Catalog.Domain.Commands.Users
{
    public class SignInUserCommand : IRequest<TokenResponse>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
