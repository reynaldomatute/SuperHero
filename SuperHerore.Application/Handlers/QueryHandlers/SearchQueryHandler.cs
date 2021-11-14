using MediatR;
using SuperHero.Core.Repositories;
using SuperHerore.Application.Commands;
using SuperHerore.Application.Mappers;
using SuperHerore.Application.Responses;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SuperHerore.Application.Handlers.QueryHandlers
{
    public class SearchQueryHandler : IRequestHandler<SearchCommand, SearchResponse>
    {
        private readonly ISuperHerorepository _superHerorepository;

        public SearchQueryHandler(ISuperHerorepository superHerorepository)
        {
            _superHerorepository = superHerorepository;
        }

        public async Task<SearchResponse> Handle(SearchCommand request, CancellationToken cancellationToken)
        {
            var response = await _superHerorepository.Search(request.Search);

            return new SearchResponse
            {
                Error = response.Error,
                ResultsFor = response.ResultsFor,
                Response = response.Response,
                Results = response?.Results?.Select(p => new Result 
                { 
                    Id= p.Id,
                    Name = p.Name,
                    Appearance = new Appearance
                    {
                        Gender = p.Appearance.Gender
                    },
                    Image = new Image
                    {
                        Url = p.Image.Url
                    }
                }).ToList()
            };
        }
    }
}
