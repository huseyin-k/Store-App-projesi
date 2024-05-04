using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{

	public int ProductId { get; set; }

	[Required(ErrorMessage = "productName is required.")]
	public String? ProductName { get; set; } = String.Empty;

	[Required(ErrorMessage = "price is required.")]
	public decimal Price { get; set; }

	public int? CategoryId {  get; set; }
	public Category? Category { get; set; }
}
