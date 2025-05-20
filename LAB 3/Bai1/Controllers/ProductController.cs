using Bai1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            // Tạo một đối tượng Product (dữ liệu mẫu)
            var product = new Product
            {
                Id = 1,
                Name = "Laptop Dell XPS 15",
                Price = 25000000
            };

            // Truyền đối tượng product sang View
            return View(product);
        }
    }
}
