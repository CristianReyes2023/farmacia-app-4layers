using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class TipoDocumento : BaseEntity
{
    [Required]
    public string NombreTipoDocumento { get; set; }
    public ICollection<Persona> Personas { get; set; }

}
