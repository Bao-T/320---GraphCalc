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
