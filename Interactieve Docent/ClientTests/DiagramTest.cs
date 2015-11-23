using System;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ClientTests
{

    [TestClass]
    public class DiagramTest
    {

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test1()

        {
            int[] aantallen = new int[] { 1, 2, 3, 4, 5 }; //waardes
            string[] antwoordnamen = new string[] { "a", "b", "c","d","e"};
            string vraagNaam = "Test"; //naam van vraag
            diagram diagram = new diagram(aantallen, antwoordnamen, vraagNaam);
            for (int i = 0; i < aantallen.Length; i++)
            {
                diagram.MaakStaaf(antwoordnamen[i], aantallen[i]);
            }
           
        }
    }
}