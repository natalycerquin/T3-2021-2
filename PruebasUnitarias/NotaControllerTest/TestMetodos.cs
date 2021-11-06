using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using T3_2021_2.Controllers;
using T3_2021_2.Interface;
using T3_2021_2.Models;

namespace PruebasUnitarias.NotaControllerTest
{
    
   public class TestMetodos
    {
        private Mock<NotaIn> _mockNot;

        [SetUp]
        public void Setup()
        {
            _mockNot = new Mock<NotaIn>();
        }

        [Test]
        public void DebeRetornarUnaListaDeNotasTest01()
        {

            _mockNot.Setup(o => o.getLisNotas()).Returns(new List<Nota>());

            var controller = new NotaController(_mockNot.Object);

            var view = controller.Index();
            Assert.IsInstanceOf<ViewResult>(view);
            Assert.IsNotInstanceOf<RedirectToRouteResult>(view);
        }
        [Test]
        public void DebePoderGuardarUnaNotaTest02()
        {
            var controller = new NotaController(_mockNot.Object);

            var view = controller.Crear("Examen Calidad", "Hay exemen estudiar")  as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(view);
            Assert.IsNotInstanceOf<ViewResult>(view);
        }
        [Test]
        public void DebePoderEditarUnaNotaTest03()
        {

            var controller = new NotaController(_mockNot.Object);

            var view = controller.Editar("Examen","estudiar",1) as RedirectToActionResult;

            Assert.IsInstanceOf<RedirectToActionResult>(view);
            Assert.IsNotInstanceOf<ViewResult>(view);
        }

        [Test]
        public void DebePoderBorrarUnaNotaTest04()
        {
             
            var controller = new NotaController(_mockNot.Object);
            var view = controller.Borrar( 1) as RedirectToActionResult;
            Assert.IsInstanceOf<RedirectToActionResult>(view);
            Assert.IsNotInstanceOf<ViewResult>(view);
        }

    }
}
