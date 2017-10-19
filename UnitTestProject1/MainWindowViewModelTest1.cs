using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class MainWindowViewModelTest1
    {
        [TestMethod]
        public void TestOverAge()
        {
            //Assamble
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            bool expectedValue = true;

            //Act
            bool actualValue = viewmodel.Overage(20);

            //Assert

            Assert.AreEqual(expectedValue,actualValue);



        }

        [TestMethod]
        public void TestUnderAge()
        {
            //Assamble
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            bool expectedValue = false;

            //Act
            bool actualValue = viewmodel.Overage(11);

            //Assert

            Assert.AreEqual(expectedValue, actualValue);



        }


        [TestMethod]
        public void TestBudapest()
        {
            //Assamble
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            bool expectedValue = true;

            //Act
            bool actualValue = viewmodel.Budapest("Budapest");

            //Assert

            Assert.AreEqual(expectedValue, actualValue);



        }

        [TestMethod]
        public void TestNotBudapest()
        {
            //Assamble
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            bool expectedValue = false;

            //Act
            bool actualValue = viewmodel.Budapest("Kecskemét");

            //Assert

            Assert.AreEqual(expectedValue, actualValue);



        }

    }
}
