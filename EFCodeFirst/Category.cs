using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Category
{
	//ClassNameId = Primary Key
	[Key]
	public int CategoryId { get; set; }
	[Required, MaxLength(15)]
	public string CategoryName { get; set; }
	[Column(TypeName = "ntext")]
	public string? Description { get; set; }
	public ICollection<Product> Products { get; set; }
	public Category() 
	{
		Products = new HashSet<Product>();
	}
}
