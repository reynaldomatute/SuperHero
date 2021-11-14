using SuperHero.Core.Entities;
using System.Threading.Tasks;

namespace SuperHero.Core.Repositories
{
    public interface ISuperHerorepository
    {
        Task<Search> Search(string filter);

        Task<Detail> Filter(int? id);
    }
}
