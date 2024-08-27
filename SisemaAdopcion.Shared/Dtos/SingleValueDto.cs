using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisemaAdopcion.Shared.Dtos
{
    public record SingleValueDto<TValue>(TValue Value);
}
