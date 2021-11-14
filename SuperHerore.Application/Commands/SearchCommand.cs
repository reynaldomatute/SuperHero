using MediatR;
using SuperHerore.Application.Responses;

namespace SuperHerore.Application.Commands
{
    public class SearchCommand : IRequest<SearchResponse>
    {
        public string Search { get; set; }
    }
}
