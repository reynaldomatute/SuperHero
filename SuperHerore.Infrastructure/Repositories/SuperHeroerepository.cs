using Microsoft.Extensions.Configuration;
using SuperHero.Core.Entities;
using SuperHero.Core.Repositories;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperHerore.Infrastructure.Repositories
{
    public class SuperHeroerepository: ISuperHerorepository
    {

        private IConfiguration _cofiguration;
        static HttpClient client = new HttpClient();
        public SuperHeroerepository(IConfiguration configuration)
        {
            _cofiguration = configuration;

        }

        public async Task<Search> Search(string filter)
        {
            var domain = _cofiguration.GetSection("SuperHeroConfig").GetSection("Domain").Value;
            var token = _cofiguration.GetSection("SuperHeroConfig").GetSection("Token").Value;
            Search search = null;

            try
            {
                HttpResponseMessage response = await client.GetAsync($"{domain}api/{token}/search/{filter}");
                if (response.IsSuccessStatusCode)
                {
                    search = await response.Content.ReadAsAsync<Search>();
                }
            }
            catch (Exception ex)
            {
                search = new Search
                {
                    Error = ex.Message,
                    Response = "error"
                };
            }


            return search;
        }

        public async Task<Detail> Filter(int? id)
        {
            var domain = _cofiguration.GetSection("SuperHeroConfig").GetSection("Domain").Value;
            var token = _cofiguration.GetSection("SuperHeroConfig").GetSection("Token").Value;
            Detail filter = null;

            try
            {
                HttpResponseMessage response = await client.GetAsync($"{domain}api/{token}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    filter = await response.Content.ReadAsAsync<Detail>();
                }
            }
            catch (Exception ex)
            {
                filter = new Detail
                {
                    Error = ex.Message,
                    Response = "error"
                };
            }


            return filter;
        }
    }
}
