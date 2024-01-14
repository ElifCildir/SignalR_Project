using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }

        public List<Procduct>Procducts { get; set; }

    }
}
