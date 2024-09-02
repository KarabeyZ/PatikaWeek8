using Microsoft.AspNetCore.Mvc;
using PratikBasicMVC.Models;

namespace PratikBasicMVC.Controllers
{
    //CustomerOrdersController sınıfı olusturuldu
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            //customer nesnesi olusturuldu
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Zekeriya",
                LastName = "Karabey",
                Email = "karabeyzekeriya@gmail.com"
            };
            //order nesneleri olusturuldu
            var orders = new List<Order>();
            orders.Add(new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Price= 25000,
                Quantity = 1
            });
            orders.Add(new Order { Id = 2, ProductName = "Mouse",Price = 5000, Quantity = 2 });
            //ViewModel nesnesi olusturuldu
            var ViewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };
            //en son viewmodel nesnesi view ' e iletildi
            return View(ViewModel);
        }
    }
}
