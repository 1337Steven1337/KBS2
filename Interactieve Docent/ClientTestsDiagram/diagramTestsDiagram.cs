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

            diagram Diagram = new diagram(3);

            CollectionAssert.AllItemsAreNotNull(Diagram.votes);
            CollectionAssert.AllItemsAreNotNull(Diagram.questions);
            Assert.AreEqual(Diagram.votes.Count,Diagram.questions.Count);
          
            Console.WriteLine("test");
        }
    }
}