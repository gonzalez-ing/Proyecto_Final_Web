using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Aplicada.Entidades;
using System.Linq.Expressions;

namespace BLL.Tests
{
    [TestClass()]
    public class DetalleVentasTests
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            bool paso = false;
            productos.Nombre = "Jabon";
            productos.Costo = 10;
            productos.Precio = 15;
            productos.ProductoId = 6;
            productos.Inventario = 5;



            paso = repositorio.Guardar(productos);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Modificar()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            var productos = repositorio.Buscar(3);
            bool paso = false;
            productos.Nombre = "Ace";
            paso = repositorio.Modificar(productos);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            int id = 2;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Buscar()
        {
            int id = 4;
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos productos = new Productos();
            productos = repositorio.Buscar(id);
            Assert.IsNotNull(productos);
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            Expression<Func<Productos, bool>> resultados = p => true;
            lista = repositorio.GetList(resultados);
            Assert.IsNotNull(lista);
        }


    }

    [TestClass]
    public class UnitTestClientes
    {
        [TestMethod]
    public void Guardar()
    {
        RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
        Clientes cliente = new Clientes();
        bool paso = false;
        cliente.ClienteId = 4;
        cliente.Fecha = DateTime.Now;
        cliente.Nombre = "Jose";
        cliente.Telefono = "8098971234";
        cliente.Cedula = "40223469836";
        cliente.Direccion = "Tenares";

        paso = repositorio.Guardar(cliente);
        Assert.AreEqual(true, paso);
    }

        [TestMethod]
        public void Modificar()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            var cliente = repositorio.Buscar(3);
            bool paso = false;
            cliente.Nombre = "Juan";
            paso = repositorio.Modificar(cliente);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            int id = 4;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Buscar()
        {
            int id = 3;
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            cliente = repositorio.Buscar(id);
            Assert.IsNotNull(cliente);
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Clientes> repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            Expression<Func<Clientes, bool>> resultados = p => true;
            lista = repositorio.GetList(resultados);
            Assert.IsNotNull(lista);
        }
    }

    [TestClass]
    public class TestVenta
    {
        [TestMethod]
        public void Guardar()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            Facturas ventas = new Facturas();
            bool paso = false;
            ventas.ClienteId = 2;
            ventas.Fecha = DateTime.Now;
            ventas.Total = 500;
            ventas.ClienteId = 1;
            ventas.FacturaId = 5;
           // ventas.Detalle.Add(new FacturasDetalles(15, 2, 150, 300));
            paso = repositorio.Guardar(ventas);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Modificar()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            var ventas = repositorio.Buscar(3);
            bool paso = false;
            ventas.ClienteId = 2;
            paso = repositorio.Modificar(ventas);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void Eliminar()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            int id = 4;
            bool paso = false;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(true, paso);
        }

        [TestMethod]
        public void Buscar()
        {
            int id = 3;
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            Facturas ventas = new Facturas();
            ventas = repositorio.Buscar(id);
            Assert.IsNotNull(ventas);
        }
        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Facturas> repositorio = new RepositorioBase<Facturas>();
            List<Facturas> lista = new List<Facturas>();
            Expression<Func<Facturas, bool>> resultados = p => true;
            lista = repositorio.GetList(resultados);
            Assert.IsNotNull(lista);
        }
    }
}

