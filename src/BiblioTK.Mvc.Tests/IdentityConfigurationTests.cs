using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTK.Models;
using System.Linq;
using System.Data.Entity;

namespace BiblioTK.Mvc.Tests
{
    [TestClass]
    public class IdentityConfigurationTests
    {
        private ApplicationDbContext db;
        public IdentityConfigurationTests()
        {
            db = new ApplicationDbContext();
            Database.SetInitializer(new ContextInitializer());
        }
        [TestMethod]
        public void CreateDataBase()
        {
            var paises = db.Paises.ToList();
        }
        [TestMethod]
        public void InitializeDb()
        {
            var paises = db.Paises.ToList();
            Assert.IsTrue(paises.Count > 0);
        }
    }
}
