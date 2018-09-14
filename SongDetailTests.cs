using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Che.Songs;

namespace Che.Tests
{
    [TestClass]
    public class SongDetailTests
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
        }
        [TestMethod]
        public void Test_Certification_600000plus()
        {           
            string realCertificationS = s.GetCertification();
            Assert.AreEqual("Platinum", realCertificationS, "", "The certification is incorrect");                     
        }
        [TestMethod]
        public void Test_Certification_400000_600000()
        {
            string realCertificationS2 = s2.GetCertification();
            Assert.AreEqual("Gold", realCertificationS2, "", "The certification is incorrect");
        }
        [TestMethod]
        public void Test_Certification_200000_400000()
        {
            string realCertificationS3 = s3.GetCertification();
            Assert.AreEqual("Silver", realCertificationS3, "", "The certification is incorrect");
        }
        [TestMethod]
        public void Test_Certification_upto_200000()
        {
            string realCertificationS4 = s4.GetCertification();
            Assert.AreSame(null, realCertificationS4, "The certification is incorrect");
        }

    }
}
