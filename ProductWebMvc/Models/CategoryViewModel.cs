using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProductWebMvc.Models
{
    public class CategoryViewModel
    {
        public int id { get; set; }

        public string title { get; set; }

        public string url { get; set; }

    }
}
