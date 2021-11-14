using MediatR;
using SuperHerore.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerore.Application.Commands
{
    public class DetailCommand : IRequest<DetailResponse>
    {
        public int? Id { get; set; }
    }
}
