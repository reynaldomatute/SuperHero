using MediatR;
using SuperHero.Core.Repositories;
using SuperHerore.Application.Commands;
using SuperHerore.Application.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace SuperHerore.Application.Handlers.QueryHandlers
{
    public class DetailQueryHandler : IRequestHandler<DetailCommand, DetailResponse>
    {
        private readonly ISuperHerorepository _superHerorepository;

        public DetailQueryHandler(ISuperHerorepository superHerorepository)
        {
            _superHerorepository = superHerorepository;
        }
        public async Task<DetailResponse> Handle(DetailCommand request, CancellationToken cancellationToken)
        {
            var response = await _superHerorepository.Filter(request.Id);

            if(response.Response == "error")
            {
                return new DetailResponse
                {
                    Error = response.Error,
                    Response = response.Response,
                };
            }


            return new DetailResponse
            {
                Id = response.Id,
                Name = response.Name,
                Error = response.Error,
                Response = response.Response,
                Appearance = new DetailAppearance
                {
                    EyeColor = response.Appearance.EyeColor,
                    Gender = response.Appearance.Gender,
                    HairColor = response.Appearance.HairColor,
                    Height = response.Appearance.Height,
                    Race = response.Appearance.Race,
                    Weight = response.Appearance.Weight
                },
                Biography = new DetailBiography
                {
                    Aliases = response.Biography.Aliases,
                    Alignment = response.Biography.Alignment,
                    AlterEgos = response.Biography.AlterEgos,
                    FirstAppearance = response.Biography.FirstAppearance,
                    FullName = response.Biography.FullName,
                    PlaceOfBirth = response.Biography.PlaceOfBirth,
                    Publisher = response.Biography.Publisher
                },
                Connections = new DetailConnection
                {
                    GroupAffiliation = response.Connections.GroupAffiliation,
                    Relatives = response.Connections.Relatives
                },
                Image = new DetailImage
                {
                    Url = response.Image.Url
                },
                Powerstats = new DetailPowerstat
                {
                    Combat = response.Powerstats.Combat,
                    Durability = response.Powerstats.Durability,
                    Intelligence = response.Powerstats.Intelligence,
                    Power = response.Powerstats.Power,
                    Speed = response.Powerstats.Speed,
                    Strength = response.Powerstats.Strength
                },
                Work = new DetailWork
                {
                    Base = response.Work.Base,
                    Occupation = response.Work.Occupation
                }
            };
        }
    }
}
