using System.ComponentModel.DataAnnotations;

namespace StepItUp.Models
{
	public class Category
	{
		[Key]
		public int CategoriesId { get; set; }
		public string Name { get; set; }
		public List<Product>? Products { get; set; }
	}
}
