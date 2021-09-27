﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityStore.BL
{
    public class ProductosBL
    {
        Contexto _contexto;//creacion de variable de tipo contexto

        public List<Producto> ListadeProductos { get; set; }



        public ProductosBL()
        {
            _contexto = new Contexto();

            ListadeProductos = new List<Producto>();

        }

        public List<Producto> ObtenerProductos()
        {
            ListadeProductos = _contexto.Productos.ToList();

            return ListadeProductos;
        }
    }
}
