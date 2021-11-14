
namespace SuperHerore.Application.Responses
{
    public class DetailResponse
    {
        public string Response { get; set; }
        public string Error { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DetailPowerstat Powerstats { get; set; }
        public DetailBiography Biography { get; set; }
        public DetailAppearance Appearance { get; set; }
        public DetailWork Work { get; set; }
        public DetailConnection Connections { get; set; }
        public DetailImage Image { get; set; }
    }

    public class DetailPowerstat
    {
        public string Intelligence { get; set; }
        public string Strength { get; set; }
        public string Speed { get; set; }
        public string Durability { get; set; }
        public string Power { get; set; }
        public string Combat { get; set; }
    }

    public class DetailBiography
    {
        public string FullName { get; set; }
        public string AlterEgos { get; set; }
        public string[] Aliases { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
    }

    public class DetailAppearance
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public string[] Height { get; set; }
        public string[] Weight { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
    }

    public class DetailWork
    {
        public string Occupation { get; set; }
        public string Base { get; set; }
    }

    public class DetailConnection
    {
        public string GroupAffiliation { get; set; }
        public string Relatives { get; set; }
    }

    public class DetailImage
    {
        public string Url { get; set; }
    }
}
