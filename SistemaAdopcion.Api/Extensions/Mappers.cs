using SisemaAdopcion.Shared.Dtos;
using SistemaAdopcion.Api.Data.Entities;

namespace SistemaAdopcion.Api.Extensions
{
    public static class Mappers
    {
        public static PetDetailDto MapToPetDetailsDto(this Pet p) =>
            new PetDetailDto
            {
                AdoptionStatus = p.AdoptionStatus,
                Breed = p.Breed,
                DateOfBirth = p.DateOfBirth,
                Description = p.Description,
                Gender = p.Gender,
                Id = p.Id,
                Image = p.Image,
                //Image = $"{AppConstants.BaseImagesUrl}/Images/pets/{p.Image}",
                Name = p.Name,
                Price = p.Price
            };
    }
}
