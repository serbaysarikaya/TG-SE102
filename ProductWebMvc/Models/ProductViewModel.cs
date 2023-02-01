using System.ComponentModel.DataAnnotations;

namespace ProductWebMvc.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Product Id")]
        public int id { get; set; }
        [Display(Name = "Product Name")]
        public string title { get; set; }

        [Display(Name = "Product Detail")]
        public string description { get; set; }

        public decimal price { get; set; }


        public int categoryId { get; set; }

        [Display(Name = "Category")]
        public string categoryName { get; set; }

        public string Url { get; set; }
    }
}
