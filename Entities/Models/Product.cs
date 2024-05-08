using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class ProductDtoForInsteriton
{

	public int ProductId { get; set; }

	public String? ProductName { get; set; } = String.Empty;

	public decimal Price { get; set; }

	public int? CategoryId {  get; set; }
	public Category? Category { get; set; }
}
