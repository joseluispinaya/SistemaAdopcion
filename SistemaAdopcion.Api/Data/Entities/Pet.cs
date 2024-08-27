using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SisemaAdopcion.Shared.Enumerations;

namespace SistemaAdopcion.Api.Data.Entities
{
    public class Pet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(25)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(180)]
        public string Image { get; set; } = null!;

        [Required, MaxLength(50)]
        public string Breed { get; set; } = null!;

        [Required]
        public Gender Gender { get; set; }

        [Required, Range(0, double.MaxValue)]
        public double Price { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; } = null!;

        public int Views { get; set; }

        public AdoptionStatus AdoptionStatus { get; set; } = AdoptionStatus.Available;

        public bool IsActive { get; set; } = true;
    }
}
