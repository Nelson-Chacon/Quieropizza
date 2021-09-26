using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityStore.BL
{
    public class ProductosBL
    {

        public List<Producto> ObtenerProductos()
        {
            var producto = new Producto();
            producto.id = 1;
            producto.Descripcion = "Iphone X";
            producto.Precio = 15000;
            producto.Existencia = 12;

            var producto1 = new Producto();
            producto1.id = 2;
            producto1.Descripcion = "Xbox 360";
            producto1.Precio = 5600;
            producto1.Existencia = 13;


            var ListadeProductos = new List<Producto>();
            ListadeProductos.Add(producto);
            ListadeProductos.Add(producto1);

            return ListadeProductos;
        }
    }
}
