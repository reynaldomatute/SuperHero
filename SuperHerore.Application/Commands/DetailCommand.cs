using MediatR;
using SuperHerore.Application.Responses;

namespace SuperHerore.Application.Commands
{
    public class DetailCommand : IRequest<DetailResponse>
    {
        public int? Id { get; set; }
    }
}
