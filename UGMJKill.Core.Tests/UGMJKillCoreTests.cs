using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UGMJKill.Core.Lib;
using System.IO;

namespace UGMJKill.Core.Tests
{
    [TestClass]
    public class UGMJKillCoreTests
    {
        [TestMethod]
        public void generateBaseDirectorys()
        {
            Manager.crearArbol();

            //Comprobar que los archivos se crearon           

            Assert.IsTrue(Directory.Exists("Pagina"));
            Assert.IsTrue(Directory.Exists("Pagina\\Template"));
        }
    }
}