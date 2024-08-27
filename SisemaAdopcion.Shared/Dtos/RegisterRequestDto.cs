using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisemaAdopcion.Shared.Dtos
{
    public class RegisterRequestDto : LoginRequestDto
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
