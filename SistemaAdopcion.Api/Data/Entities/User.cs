﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaAdopcion.Api.Data.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(100)]
        public string Email { get; set; } = null!;

        //[Required, MaxLength(10)]
        //public string Salt { get; set; }

        //[Required, MaxLength(80)]
        //public string Hash { get; set; }

        [Required, MaxLength(10)]
        public string Password { get; set; } = null!;
    }
}
