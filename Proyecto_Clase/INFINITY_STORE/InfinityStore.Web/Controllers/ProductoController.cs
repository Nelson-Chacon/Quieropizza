using InfinityStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InfinityStore.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var producto = new ProductoModel();
            producto.id = 1;
            producto.Descripcion = "Iphone X";

            var producto1 = new ProductoModel();
            producto1.id = 2;
            producto1.Descripcion = "Xbox 360";

            var ListadeProductos = new List<ProductoModel>();

            ListadeProductos.Add(producto);
            ListadeProductos.Add(producto1);
            return View(ListadeProductos);
        }
    }
}