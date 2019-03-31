using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final_Aplicada.Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class DetalleVentasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombre = "Adrian";
            usuarios.NombreUsuario = "Admin";
            usuarios.Clave = "1234";

            paso = repositorio.Guardar(usuarios);
            Assert.AreEqual(paso, true);
        }


        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso = false;
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 1;
            usuarios.Nombre = "Esteban";
            usuarios.NombreUsuario = "Empleado";
            usuarios.Clave = "4321";

            paso = repositorio.Modificar(usuarios);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            int id = 1;
            Usuarios usuarios = new Usuarios();
            usuarios = repositorio.Buscar(id);
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            
            var Lista = repositorio.GetList(x => true);
            Assert.IsNotNull(Lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            bool paso;
            int id = 1;
            paso = repositorio.Eliminar(id);
            Assert.AreEqual(paso, false);
        }


    }
}