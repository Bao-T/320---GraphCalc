using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace GraphCalcTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestGreaterThan
    {
        private ApplicationUnderTest testapp;
        [TestInitialize()]
        public void MyTestInitialize()
        {
            testapp = ApplicationUnderTest.Launch(@"C:\GraphCalc\GrphCalc.exe");
        }
        public TestGreaterThan()
        {
        }

        [TestMethod]
        public void FourGreaterThanTwo()
        {
            this.UIMap.FourGreaterThanTwo3();
            this.UIMap.AssertFourGreaterThanTwo2();
        }

        [TestMethod]
        public void TwoGreaterThanTwo()
        {
            this.UIMap.TestTwoGreaterThanTwo();
            this.UIMap.AssertTwoGreaterThanTwo();
        }

        [TestMethod]
        public void OneGreaterThanTwo()
        {
            this.UIMap.TestOneGreaterThanTwo();
            this.UIMap.AssertOneGreaterThanTwo();
        }

        [TestMethod]
        public void ZeroGreaterThanMinusOne()
        {
            this.UIMap.TestZeroGreaterThanMinusOne();
            this.UIMap.AssertZeroGreaterThanMinusOne();
        }

        [TestMethod]
        public void MinusOneGreaterThanMinusTwo()
        {
            this.UIMap.TestMinusOneGreaterThanMinusTwo();
            this.UIMap.AssertMinusOneGreaterThanMinusTwo();
        }

        [TestMethod]
        public void MinusTwoGreaterThanMinusOne()
        {
            this.UIMap.TestMinusTwoGreaterThanMinusOne();
            this.UIMap.AssertMinusTwoGreaterThanMinusOne();
        }

        [TestMethod]
        public void MinusOneGreaterThanZero()
        {
            this.UIMap.TestMinusOneGreaterThanZero();
            this.UIMap.AssertMinusOneGreaterThanZero();
        }

        [TestMethod]
        public void ZeroGreaterThanZero()
        {
            this.UIMap.TestZeroGreaterThanZero();
            this.UIMap.AssertZeroGreaterThanZero();
        }

        [TestMethod]
        public void TenGreaterThanTwo()
        {
            this.UIMap.TestTenGreaterThanTwo();
            this.UIMap.AssertTenGreaterThanTwo();
        }

        [TestMethod]
        public void OnehundredGreaterThanTwo()
        {
            this.UIMap.TestOnehundredGreaterThanTwo();
            this.UIMap.AssertOnehundredGreaterThanTwo();
        }

        [TestMethod]
        public void TwoGreaterThanOneTen()
        {

            this.UIMap.TestTwoGreaterThanTen();
            this.UIMap.AssertTwoGreaterThanTen();

        }

        [TestMethod]
        public void TwoGreaterThanOnehundred()
        {

            this.UIMap.TestTwoGreaterThanOnehundred();
            this.UIMap.AssertTwoGreaterThanOnehundred();

        }

        [TestMethod]
        public void OnethousandGreaterThanTwo()
        {

            this.UIMap.TestOnethousandGreaterThanTwo();
            this.UIMap.AssertOnethousandGreaterThanTwo();

        }

        [TestMethod]
        public void TwoGreaterThanOnethousand()
        {

            this.UIMap.TestTwoGreaterThanOnethousand();
            this.UIMap.AssertTwoGreaterThanOnethousand();

        }

        [TestMethod]
        public void TenthousandGreaterThanTwo()
        {

            this.UIMap.TestTenthousandGreaterThanTwo();
            this.UIMap.AssertTenthousandGreaterThanTwo();

        }
        //Absolute Value
        [TestMethod]
        public void ABSMinusOne()
        {

            this.UIMap.TestABSMinusOne();
            this.UIMap.AssertABSMinusOne();

        }

        [TestMethod]
        public void ABSOne()
        {

            this.UIMap.TestABSOne();
            this.UIMap.AssertABSOne();

        }

        [TestMethod]
        public void ABSOnePointTwo()
        {

            this.UIMap.TestABSOnePointTwo();
            this.UIMap.AssertABSOnePointTwo();

        }

        [TestMethod]
        public void ABSMinusOnePointTwo()
        {

            this.UIMap.TestABSMinusOnePointTwo();
            this.UIMap.AssertABSMinusOnePointTwo();

        }

        [TestMethod]
        public void ABSOneMillion()
        {

            this.UIMap.TestABSOneMillion();
            this.UIMap.AssertABSOneMillion();

        }

        [TestMethod]
        public void ABSMinusOneMillion()
        {

            this.UIMap.TestABSMinusOneMillion();
            this.UIMap.AssertABSMinusOneMillion();

        }

        [TestMethod]
        public void ABSMinusOneMinusThree()
        {

            this.UIMap.TestABSMinusOneMinusThree();
            this.UIMap.AssertABSMinusOneMinusThree();

        }

        [TestMethod]
        public void ABSZero()
        {

            this.UIMap.TestABSZero();
            this.UIMap.AssertABSZero();

        }

        [TestMethod]
        public void ABSThirty()
        {

            this.UIMap.TestABSThirty();
            this.UIMap.AssertABSThirty();

        }

        [TestMethod]
        public void ABSMinusThirty()
        {

            this.UIMap.TestABSMinusThirty();
            this.UIMap.AssertABSMinusThirty();

        }

        [TestMethod]
        public void ABSMinusOneFourth()
        {

            this.UIMap.TestABSMinusOneFourth();
            this.UIMap.AssertABSMinusOneFourth();

        }

        [TestMethod]
        public void ABSOneFourth()
        {

            this.UIMap.TestABSOneFourth();
            this.UIMap.AssertABSOneFourth();

        }

        [TestMethod]
        public void ABSOneFifth()
        {

            this.UIMap.TestABSOneFifth();
            this.UIMap.AssertABSOneFifth();

        }

        [TestMethod]
        public void FourLessThanTwo()
        {

            this.UIMap.TestFourLessThanTwo();
            this.UIMap.AssertFourLessThanTwo();

        }

        [TestMethod]
        public void TwoLessThanTwo()
        {

            this.UIMap.TestTwoLessThanTwo();
            this.UIMap.AssertTwoLessThanTwo();

        }

        [TestMethod]
        public void OneLessThanTwo()
        {

            this.UIMap.TestOneLessThanTwo();
            this.UIMap.AssertOneLessThanTwo();

        }

        [TestMethod]
        public void ZeroLessThanMinusOne()
        {

            this.UIMap.TestZeroLessThanMinusOne();
            this.UIMap.AssertZeroLessThanMinusOne();

        }

        [TestMethod]
        public void MinusOneLessThanMinusTwo()
        {

            this.UIMap.TestMinusOneLessThanMinusTwo();
            this.UIMap.AssertMinusOneLessThanMinusTwo();

        }

        [TestMethod]
        public void MinusTwoLessThanMinusOne()
        {

            this.UIMap.TestMinusTwoLessThanMinusOne();
            this.UIMap.AssertMinusTwoLessThanMinusOne();

        }

        [TestMethod]
        public void MinusOneLessThanZero()
        {

            this.UIMap.TestMinusOneLessThanZero();
            this.UIMap.AssertMinusOneLessThanZero();

        }

        [TestMethod]
        public void ZeroLessThanZero()
        {

            this.UIMap.TestZeroLessThanZero();
            this.UIMap.AssertZeroLessThanZero();

        }

        [TestMethod]
        public void TenLessThanTwo()
        {

            this.UIMap.TestTenLessThanTwo();
            this.UIMap.AssertTenLessThanTwo();

        }

        [TestMethod]
        public void OneHundredLessThanTwo()
        {

            this.UIMap.OneHundredLessThanTwo();
            this.UIMap.AssertOnehundredLessThanTwo();

        }
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
