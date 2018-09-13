using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Songs;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Song s;
        Song s2;
        Song s3;
        Song s4;
        [TestInitialize]
        public void InitialiseSongTest()
        {
            s = new Song("Dear Mama", "Tupac", 1400000);
            s2 = new Song("Changes", "Tupac", 580000);
            s3 = new Song("Ghetto Gospel", "Tupac", 390000);
            s4 = new Song("Smile", "Tupac", 190000);

        }
        [TestMethod]
        public void TestDetails()
        {
            string realDetailsS = s.GetDetails();
            Assert.AreEqual("Name: Dear Mama Artist: Tupac Copies Sold: 1400000", realDetailsS, "", "The details of the track do not match.");
            string realDetailsS2 = s2.GetDetails();
            Assert.AreEqual("Name: Changes Artist: Tupac Copies Sold: 580000", realDetailsS2, "", "The details of the track do not match.");

        }
        [TestMethod]
        public void TestCertification()
        {
            string realCertification = s.GetCertification();
            Assert.AreEqual("Platinum", realCertification, "", "The certification is incorrect");
        }

    }
}
