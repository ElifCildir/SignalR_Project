using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }

    }
}
