using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using porkshopReact.Model;
using System.Data;
using System.Data.SqlClient;

namespace porkshopReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ShoppingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("ProductList")]
        public Response GetAllProducts()
        {
            Response response = new();
            List<Product> productList = new();
            SqlConnection connection = new (_configuration.GetConnectionString("sqlconnect").ToString());
            SqlDataAdapter adapter = new ("SELECT * from dbo.products", connection);
            DataTable data = new ();
            adapter.Fill(data);

            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Product products = new()
                    {
                        ProductId = Convert.ToInt32(data.Rows[i]["ProductId"]),
                        ProductName = Convert.ToString(data.Rows[i]["ProductName"]),
                        ProductPrice = (double)Convert.ToDecimal(data.Rows[i]["ProductPrice"]),
                        Quantity = Convert.ToInt32(data.Rows[i]["Quantity"]),
                        Description = Convert.ToString(data.Rows[i]["Description"])
                    };
                    productList.Add(products);
                }
                if (productList.Count > 0)
                {
                    response.StatusCode = 200;
                    response.StatusMessage = "Data Found!";
                    response.Listproducts = productList;
                }
                else
                {
                    response.StatusCode = 100;
                    response.StatusMessage = "Data Not Found!";
                    response.Listproducts = null;
                }
            }
            else
            {
                response.StatusCode = 100;
                response.StatusMessage = "Data Not Found!";
                response.Listproducts = null;
            }
            return response;
        }
    }
}
