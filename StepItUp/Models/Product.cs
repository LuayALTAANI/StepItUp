using System.ComponentModel.DataAnnotations;

namespace StepItUp.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Size { get; set; }
		public decimal Price { get; set; }
		public string Color { get; set; }
		public string? Photos { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
