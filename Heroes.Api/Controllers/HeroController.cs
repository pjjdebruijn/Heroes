using Microsoft.AspNetCore.Mvc;

namespace Heroes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {

        private static readonly string[] Description = new[]
        {
            "The name says it all", 
            "It's all in the name", 
            "Interesting character", 
            "Doesn't like monday mornings", 
            "Talks Too Much", 
            "Likes pizza", 
            "Went to the same school as chuck norris (it was a big school ok....)",
            "Is grabbing a coffee, thinking of silly descriptions...",
            "Drinks too much coffee, too late",
        };

        private static readonly bool[] falseWins = new[]
        {
            true,false,false
        };

        private static readonly bool[] trueWins = new[]
        {
            true,true,false
        };

        private static readonly string[] HeroFirstName = new[]
        {
            "Spider", "Cat", "Super", "Wonder", "Mega", "Silver", "Lightning", "Bat", "The Invisible", "Wolf", "Bruce", "Chuck" , "Shaka"
        };

        private static readonly string[] HeroLastName = new[]
        {
            "Man", "Woman", "Boy", "Girl", "Surfer", "Rider", "Demon", "Willis", "Norris", "Zulu"
        };

        private static readonly string[] Gender = new[]
        {
            "Male", "Female", "Complicated"
        };

        private readonly ILogger<HeroController> _logger;

        public HeroController(ILogger<HeroController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHeroes")]
        public async Task<IEnumerable<Hero>> GetAsync()
        {
            var Heroes = new List<Hero>();

            for (int index = 0; index < 30; index++)
            {
                var hero = new Hero
                {
                    Id = index,
                    Description = Description[Random.Shared.Next(Description.Length)],
                    HeroName = $"{HeroFirstName[Random.Shared.Next(HeroFirstName.Length)]} {HeroLastName[Random.Shared.Next(HeroLastName.Length)]}",
                    IsEvilHero = falseWins[Random.Shared.Next(falseWins.Length)],
                    IsFictional = trueWins[Random.Shared.Next(trueWins.Length)],
                    VehicleId = $"A2#{index}-B{index + 45}-S",
                    Gender = Gender[Random.Shared.Next(Gender.Length)],
                };
                Heroes.Add(hero);
            }

            return await Task.FromResult(Heroes);
        }
    }
}