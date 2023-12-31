using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Inventario : BaseEntityString
{
    [Required]
    public string NombreInventario { get; set; }
    [Required]
    public double Precio { get; set; }
    [Required]
    public int Stock { get; set; }
    [Required]
    public int StockMin { get; set; }
    [Required]
    public int StockMax { get; set; }
    public string IdCodProductoFk { get; set; }
    public Producto Productos { get; set; }
    public int IdPresentacionFk { get; set; }
    public Presentacion Presentaciones {get;set;}
    public ICollection<DetalleMovInventario> DetalleMovInventarios { get; set; }
}
