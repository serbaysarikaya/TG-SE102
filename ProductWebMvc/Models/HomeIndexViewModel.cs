using ProductWebMvc.Services;

namespace ProductWebMvc.Models
{
    public class HomeIndexViewModel
    {
       
        public IEnumerable<CategoryViewModel> Categories { get; set; }
         public IEnumerable<ProductViewModel> Products { get; set; }
      
        public HomeIndexViewModel(HttpClient httpClient,int? categoryId)
        {
           
            ProductService service = new ProductService(httpClient);
            Products = service.GetProducts(categoryId).Result;
            
            Categories =  service.GetCategories().Result;

        }
    }
}
