using Newtonsoft.Json;
using System.Collections.Generic;

namespace SuperHero.Core.Entities
{
    public class Search
    {
        public string Response { get; set; }
        public string Error { get; set; }
        [JsonProperty(PropertyName = "results-for")]
        public string ResultsFor { get; set; }
        public List<Result> Results { get; set; }
    }
    public class Result
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Powerstat Powerstats { get; set; }
        public Biography Biography { get; set; }
        public Appearance Appearance { get; set; }
        public Work Work { get; set; }
        public Connection Connections { get; set; }
        public Image Image { get; set; }
    }

    public class Detail
    {
        public string Response { get; set; }
        public string Error { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Powerstat Powerstats { get; set; }
        public Biography Biography { get; set; }
        public Appearance Appearance { get; set; }
        public Work Work { get; set; }
        public Connection Connections { get; set; }
        public Image Image { get; set; }
    }
    public class Powerstat
    {
        public string Intelligence { get; set; }
        public string Strength { get; set; }
        public string Speed { get; set; }
        public string Durability { get; set; }
        public string Power { get; set; }
        public string Combat { get; set; }
    }

    public class Biography
    {
        [JsonProperty(PropertyName = "full-name")]
        public string FullName { get; set; }
        [JsonProperty(PropertyName = "alter-egos")]
        public string AlterEgos { get; set; }
        public string[] Aliases { get; set; }
        [JsonProperty(PropertyName = "place-of-birth")]
        public string PlaceOfBirth { get; set; }
        [JsonProperty(PropertyName = "first-appearance")]
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
    }

    public class Appearance
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public string[] Height { get; set; }
        public string[] Weight { get; set; }
        [JsonProperty(PropertyName = "eye-color")]
        public string EyeColor { get; set; }
        [JsonProperty(PropertyName = "hair-color")]
        public string HairColor { get; set; }
    }

    public class Work
    {
        public string Occupation { get; set; }
        public string Base {get;set;}
    }

    public class Connection
    {
        [JsonProperty(PropertyName = "group-affiliation")]
        public string GroupAffiliation { get; set; }
        public string Relatives { get; set; }
    }

    public class Image
    {
        public string Url { get; set; }
    }

}
