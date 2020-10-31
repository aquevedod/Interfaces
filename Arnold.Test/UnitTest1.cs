using Arnold.Core;
using Arnold.DataAccess.EF;
using Arnold.DataAccess.SQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Arnold.Test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var provider = new SqlCrud();
        //}

        [TestMethod]
        public void UsingEF()
        {
            var manager = new Manager(new EFCrud());
            Assert.IsTrue(manager.GetAllItems().Count() > 10);
        }

        [TestMethod]
        public void UsingSQL()
        {
            var manager = new Manager(new SqlCrud());
            Assert.IsTrue(manager.GetAllItems().Count() <= 10);
        }


    }
}
