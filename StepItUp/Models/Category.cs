namespace StepItUp.Models
{
	public class Category
	{
		public int CategoriesId { get; set; }
		public string Name { get; set; }
		public List<Product>? Products { get; set; }
	}
}
