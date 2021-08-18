using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class TechTests
    {
        Computer testComputer;
        Laptop testLaptop;
        SmartPhone testPhone;

        [TestInitialize]
        public void CreateObjects()
        {
            testComputer = new Computer("Yoga", "Megan", 2021, 512.0, "Windows 10");
            testLaptop = new Laptop("Yoga", "Megan", 2021, 512.0, "Windows 10", "SSD");
            testPhone = new SmartPhone("iPhone", "Megan", 2019, 32.0, "iOS 8.3");
        }
        
        [TestMethod]
        public void OwnerUpdatesWhenComputerIsSold()
        {
            testComputer.Sell("James");
            Assert.IsTrue(testComputer.Owner == "James");
        }

        [TestMethod]
        public void OperatingSystemUpdatesWhenComputerIsUpdated()
        {
            testComputer.Update("Windows 11");
            Assert.IsTrue(testComputer.OperatingSystem == "Windows 11");
        }

        [TestMethod]
        public void LaptopCallsBaseConstructor()
        {
            Assert.IsTrue(testLaptop.OperatingSystem == "Windows 10");
        }

        [TestMethod]
        public void LaptopInheritsSellMethod()
        {
            testLaptop.Sell("James");
            Assert.IsTrue(testLaptop.Owner == "James");
        }

        [TestMethod]
        public void LaptopInstallsSoftware()
        {
            testLaptop.installSoftware("AutoCAD");
            Assert.IsTrue(testLaptop.Software.Contains("AutoCAD"));
        }

        [TestMethod]
        public void SmartPhoneCallsBaseConstructor()
        {
            Assert.IsTrue(testPhone.Storage == 32.0);
        }

        [TestMethod]
        public void SmartPhoneInheritsSellMethod()
        {
            testPhone.Sell("James");
            Assert.IsTrue(testPhone.Owner == "James");
        }

        [TestMethod]
        public void SmartPhoneDownloadsApplication()
        { 
            testPhone.downloadApp("Instagram");
            Assert.IsTrue(testPhone.Applications.Contains("Instagram"));
        }
    }
}
