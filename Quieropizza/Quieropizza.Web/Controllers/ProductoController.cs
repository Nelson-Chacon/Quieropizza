using Quieropizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quieropizza.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza suprema";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza Cuatro quesos";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Napolitana o romana";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza hawaiana";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = "Pizza super chesse";

            var ListaProductos =  new List<ProductoModel>();

            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
            ListaProductos.Add(producto4);
            ListaProductos.Add(producto5);


            return View(ListaProductos);
        }
    }
}