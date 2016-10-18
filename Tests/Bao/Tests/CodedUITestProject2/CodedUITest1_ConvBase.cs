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
namespace CodedUITestProject2
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    ///    Random rnd = new Random();
    [CodedUITest]
    public class CodedUITest1_ConvBase
    {
        private ApplicationUnderTest testapp;
        public CodedUITest1_ConvBase()
        {
        }
        [TestInitialize()]
        public void MyTestInitialize()
        {
            testapp = ApplicationUnderTest.Launch(@"C:\Program Files (x86)\GraphCalc\GrphCalc.exe");
        }
        [TestMethod]
        public void TestingAddition()
        {
            Random rnd = new Random();
            int x = rnd.Next();
            int y = rnd.Next();
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Addition();
            this.UIMap.AssertAddition();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestingSubtraction()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Subtraction();
            this.UIMap.AssertSubtraction();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestingMultiplication()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Multiplication();
            this.UIMap.AssertMultiplication();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestingDivision()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Division();
            this.UIMap.AssertDivision();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestingPowers()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.Power();
            this.UIMap.AssertPowers();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestNonFunctionEntry()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.NonFunction();
            this.UIMap.AssertNonFunction();
            this.UIMap.ClearOutput();
            this.UIMap.NonFunctionZero();
            this.UIMap.AssertNonFunctionZero();
            this.UIMap.ClearOutput();
        }
        [TestMethod]
        public void TestNullEntry()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.EmptyEntryBox();
            this.UIMap.AssertEmptyEntry();
        }
        [TestMethod]
        public void TestClickAllNumberButtons()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.NumberButtons();
            this.UIMap.AssertNumberedButtons();
        }
        [TestMethod]
        public void TestSquareRoot()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.SquareRoot();
            this.UIMap.AssertSquareRoot();
        }
        [TestMethod]
        public void TestSinCosTan()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.SinBasic();
            this.UIMap.AssertSinBasic();
            this.UIMap.ClearOutput();
            this.UIMap.CosBasic();
            this.UIMap.AssertCosBasic();
            this.UIMap.ClearOutput();
            this.UIMap.TanBasic();
            this.UIMap.AssertTanBasic();
            this.UIMap.ClearOutput();
        }
        // From this point, we will be testing the convert to base 'X' function.
        [TestMethod]
        public void TestConvertBaseBinary()
        {
            this.UIMap.OneToBinary();
            this.UIMap.AssertOneToBinary();
            this.UIMap.ZeroConvertToBinary();
            this.UIMap.AssertZeroToBinary();
        }
        [TestMethod]
        public void TestConvertBaseBinaryNULLEntry()
        {
            this.UIMap.ConvertBaseBinaryNull();
            this.UIMap.AssertConveryBinaryNull();
        }
        [TestMethod]
        public void TestConvertBaseConvertBase()
        {
            this.UIMap.ConvertBaseConvertBase();
            this.UIMap.AssertConvertBaseConvertBase();
        }
        [TestMethod]
        public void TestConvertBase1to36()
        {
            this.UIMap.ConvertBase1to36();
            this.UIMap.AssertConvertBase1to36();
        }
        [TestMethod]
        public void TestConvertBase0()
        {
            this.UIMap.ConvertToBaseZero();
            this.UIMap.AssertConvertToBaseZero();
        }
        [TestMethod]
        public void TestConvertBase37()
        {
            this.UIMap.ConvertToBase37();
            this.UIMap.AssertConvertToBase37();
        }
        [TestMethod]
        public void TestConvertBaseNegativeBase()
        {
            this.UIMap.ConvertBaseNegative();
            this.UIMap.AssertConvertBaseNegative();
        }
        [TestMethod]
        public void TestConvertBase100000()
        {
            this.UIMap.ConvertBase100000();
            this.UIMap.AssertConvertBase100000();
        }
        [TestMethod]
        public void TestConvertBaseOne()
        {
            this.UIMap.ConvertBase1();
            this.UIMap.AssertConvertBase1();
        }
        [TestMethod]
        public void TestConvertBetweenBases()
        {
            this.UIMap.ConvertBaseBetweenBases();
            this.UIMap.AssertConvertBaseBetweenBases();
        }
        [TestMethod]
        public void TestConvertBaseNegativeNumber()
        {
            this.UIMap.ConvertBaseNegativeNumber();
            this.UIMap.AssertConvertBaseNegativeNumber();
        }
        [TestMethod]
        public void TestConvertBaseNonInteger()
        {
            this.UIMap.ConvertBaseNonInteger();
            this.UIMap.AssertConvertBaseNonInteger();
        }
        [TestMethod]
        public void TestConvertBaseIrrationalNumber()
        {
            this.UIMap.ConvertBaseIrrationalNumber();
            this.UIMap.AssertConverBaseIrrationalNUmber();
        }
        [TestMethod]
        public void TestConvertBaseIrrationalBase()
        {
            this.UIMap.ConvertBaseIrrationalBase();
            this.UIMap.AssertConvertToBaseIrrationalBase();
        }
        [TestMethod]
        public void TestConvertBaseDecimalBase()
        {
            this.UIMap.ConvertToBaseDecimalBase();
            this.UIMap.AssertConvertToBaseDecimalBase();
        }
        [TestMethod]
        public void TestConvertBaseWithFunctionAsBase()
        {
            this.UIMap.ConvertBaseWithFunctionAsBase();
            this.UIMap.AssertConvertBaseWithFunctionAsBase();
        }
        [TestMethod]
        public void TestConvertBaseButton()
        {
            this.UIMap.ConvertBaseButton();
            this.UIMap.AssertConvertBaseButton();
        }
        [TestMethod]
        public void TestConvertBaseButtonEmptyInput()
        {
            this.UIMap.ConvertBaseEmptyInput();
            this.UIMap.AssertConvertBaseButtonEmptyInput();
        }
        [TestMethod]
        public void TestConvertBaseFunctionAsNumber()
        {
            this.UIMap.ConvertBaseFunctionAsNumber();
            this.UIMap.AssertConverBaseFunctionAsNumber();
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
