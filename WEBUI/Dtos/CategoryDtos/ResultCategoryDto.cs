using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.CategoryDtos
{
	public class ResultCategoryDto
	{
		[Key ]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public bool Status { get; set; }

	}
}
