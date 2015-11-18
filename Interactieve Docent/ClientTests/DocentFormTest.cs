using System;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ClientTests
{
    [TestClass]
    public class DocentFormTest
    {
        Client.DocentForm df = new DocentForm();
        [TestMethod]
        public void ValidateEmptyFieldsSomeEmpty()
        {
            Boolean expected = true;
            Boolean result = df.ValidateEmptyFields();
            Assert.AreEqual(expected, result, "Fields are not displayed as empty!");
        }

        [TestMethod]
        public void btnOpslaan_Click()
        {
            df.Opslaan();
        }
    }
}
