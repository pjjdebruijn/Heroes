using System.ComponentModel.DataAnnotations;

namespace Heroes.Api
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string HeroName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsEvilHero { get; set; } = false;

        public bool IsFictional { get; set; } = true;

        [Key]
        public string VehicleId { get; set; } = string.Empty;
    }
}