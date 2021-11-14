using SuperHero.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Core.Repositories
{
    public interface ISuperHerorepository
    {
        Task<Search> Search(string filter);

        Task<Detail> Filter(int? id);
    }
}
