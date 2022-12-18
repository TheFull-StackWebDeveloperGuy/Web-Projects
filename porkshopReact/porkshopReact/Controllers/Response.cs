using porkshopReact.Model;

namespace porkshopReact.Controllers
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string? StatusMessage { get; set; }
        public List<Product>? Listproducts { get; set; }
    }
}
