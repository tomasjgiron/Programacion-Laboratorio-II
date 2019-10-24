using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarListaInstanciada()//se le podría agregar parametro
        {
            Centralita centralita = new Centralita("TomiCenter");
            Assert.IsNotNull(centralita.ListLlamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LanzarExceptionLocal()
        {
            Centralita central = new Centralita("TomiCenter");
            Llamada call = new Local("Bernal", 30, "Rosario", 2.65f);
            Llamada call2 = new Local("Bernal", 20, "Rosario", 3.80f);
            central += call;
            central += call2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LanzarExceptionProvincial()
        {
            Centralita central = new Centralita("TomiCenter");
            Llamada call = new Provincial("Bernal", Provincial.Franja.Franja_1,2.65f, "Rosario");
            Llamada call2 = new Provincial("Bernal", Provincial.Franja.Franja_1, 2.65f, "Rosario");
            central += call;
            central += call2;
        }

        [TestMethod]
        public void LanzarExceptionTodas()
        {
            Llamada call = new Local("Bernal", 30, "Rosario", 2.65f);
            Llamada call2 = new Local("Bernal", 20, "Rosario", 3.80f);
            Llamada call3 = new Provincial("Bernal", Provincial.Franja.Franja_1, 2.65f, "Rosario");
            Llamada call4 = new Provincial("Bernal", Provincial.Franja.Franja_1, 2.65f, "Rosario");

            Assert.AreEqual(call, call2);
            Assert.AreNotEqual(call, call3);
            Assert.AreNotEqual(call, call4);
            Assert.AreNotEqual(call2, call3);
            Assert.AreNotEqual(call2, call4);
            Assert.AreEqual(call3, call4);
        }
    }
}
