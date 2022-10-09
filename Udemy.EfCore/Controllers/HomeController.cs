using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.EfCore.Data.Context;

namespace Udemy.EfCore.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            UdemyContext context = new();

            //add Product

            //context.Products.Add(new Data.Entities.Product
            //{
            //       Name="Laptop",
            //       Price=2000
            //});

            //UPDATE PRODUCT


            //var updatedproduct=context.Products.Find(1);

            //updatedproduct.Price = 4000;

            //context.Products.Update(updatedproduct);


            var deletedproduct = context.Products.FirstOrDefault(x => x.Id == 1);

            context.Products.Remove(deletedproduct);

            context.SaveChanges();
            return View();
        }
    }
}
