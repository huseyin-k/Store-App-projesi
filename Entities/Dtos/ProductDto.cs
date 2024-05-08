using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
	public record ProductDto
	{
		public int ProductId { get; init; }

		[Required(ErrorMessage = "productName is required.")]
		public String? ProductName { get; init; } = String.Empty;

		[Required(ErrorMessage = "price is required.")]
		public decimal Price { get; init; }

		public int? CategoryId { get; init; }
		
	}
}
