using ProductWebMvc.Models;
using System.Text.Json;

namespace ProductWebMvc.Services
{
    public class ProductService
    {
        private HttpClient _client;

        public ProductService(HttpClient client)
        {
            _client = client;
        }


        public  async Task<IEnumerable<CategoryViewModel>> GetCategories() 
        {
            string Url = "https://localhost:7049/api/Category";
            string response = await _client.GetStringAsync(Url);
            var json = JsonSerializer.Deserialize<IEnumerable<CategoryViewModel>>(response);
            return json;
        }

        public  async Task<IEnumerable<ProductViewModel>> GetProducts(int? categoryId ) 
        {
            string Url = "https://localhost:7049/api/products";
            string response = categoryId !=null? await _client.GetStringAsync($"{Url}/{categoryId}"): await _client.GetStringAsync(Url);
            var json = JsonSerializer.Deserialize<IEnumerable<ProductViewModel>>(response);
            return json;
        }
      

        private async Task<string> GetData(string soruce)
        {
            return await _client.GetStringAsync(soruce);
        }
    }
}
