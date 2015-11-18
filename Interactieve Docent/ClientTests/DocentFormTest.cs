using System;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClientTests
{
    [TestClass]
    public class DocentFormTest
    {
        [TestMethod]
        public void ValidateEmptyFieldsSomeEmpty()
        {
            Client.DocentForm df = new DocentForm();
            Boolean expected = true;
            Boolean result = df.ValidateEmptyFields();
            Assert.AreEqual(expected, result, "Fields are not displayed as empty!");
        }

        [TestMethod]
        public void btnOpslaan_Click()
        {
            
        }
    }
}
