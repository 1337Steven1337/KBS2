using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TestsDiagram
{
    [TestClass()]
    public class diagramTestsDiagram
    {
        [TestMethod()]
        public void diagramTestDiagram()
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);

            List<string> b = new List<string>();
            b.Add("a");
            b.Add("b");
            b.Add("c");

            diagram Diagram = new diagram(a,b,"test");

            CollectionAssert.AllItemsAreNotNull(Diagram.values);
            CollectionAssert.AllItemsAreNotNull(Diagram.answerNames);
            Assert.AreEqual(Diagram.values.Count,Diagram.answerNames.Count);
          
            Console.WriteLine("test");
        }
    }
}