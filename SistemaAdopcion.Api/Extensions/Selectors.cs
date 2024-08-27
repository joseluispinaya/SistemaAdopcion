using SisemaAdopcion.Shared.Dtos;
using SistemaAdopcion.Api.Data.Entities;
using System.Linq.Expressions;

namespace SistemaAdopcion.Api.Extensions
{
    public static class Selectors
    {
        public static Expression<Func<Pet, PetListDto>> PetToPetListDto =>
            p => new PetListDto
            {
                Breed = p.Breed,
                Id = p.Id,
                Image = p.Image,
                //Image = $"{AppConstants.BaseImagesUrl}/images/pets/{p.Image}",
                Name = p.Name,
                Price = p.Price
            };
    }
}
