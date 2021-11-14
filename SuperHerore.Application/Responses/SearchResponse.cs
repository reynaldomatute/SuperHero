using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHerore.Application.Responses
{
    public class SearchResponse
    {
        public string Response { get; set; }
        public string Error { get; set; }
        public string ResultsFor { get; set; }
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Appearance Appearance { get; set; }
        public Image Image { get; set; }
    }

    public class Appearance
    {
        public string Gender { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
    }
}
