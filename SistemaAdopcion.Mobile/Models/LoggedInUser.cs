﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaAdopcion.Mobile.Models
{
    public record LoggedInUser(int Id, string Name, string Token)
    {
        public string ToJson() =>
            JsonSerializer.Serialize(this);

        public static LoggedInUser? LoadFromJson(string? json) =>
            !string.IsNullOrWhiteSpace(json)
            ? JsonSerializer.Deserialize<LoggedInUser>(json)
            : default;
    }
}
