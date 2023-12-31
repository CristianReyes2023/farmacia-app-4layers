using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class FormaPago : BaseEntity
{
    [Required]
    public string NombreFormaPago { get; set; }
    public ICollection<MovimientoInventario> MovimientoInventarios { get; set; }
}
