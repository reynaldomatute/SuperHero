using MediatR;
using SuperHerore.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerore.Application.Commands
{
    public class SearchCommand : IRequest<SearchResponse>
    {
        public string Search { get; set; }
    }
}
