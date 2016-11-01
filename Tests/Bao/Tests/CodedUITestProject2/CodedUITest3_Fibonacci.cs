using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodedUITestProject2
{
    /// <summary>
    ///     Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest3_Fibonacci
    {
        private UIMap map;
        private ApplicationUnderTest testapp;

        /// <summary>
        ///     Gets or sets the test context which provides
        ///     information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        public UIMap UIMap
        {
            get
            {
                if (map == null)
                    map = new UIMap();

                return map;
            }
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            testapp = ApplicationUnderTest.Launch(@"C:\Program Files (x86)\GraphCalc\GrphCalc.exe");
        }

        [TestMethod]
        public void Fibonacci_Zero_Input()
        {
            UIMap.Fibonacci_Zero_Input();
            UIMap.Assert_Fibonacci_Zero_Input();
        }

        [TestMethod]
        public void Fibonacci_Negative_Input()
        {
            UIMap.Fibonacci_Negative_Input();
            UIMap.Assert_Fibonacci_Negative_Input();
        }

        [TestMethod]
        public void Fibonacci_Large_Input()
        {
            UIMap.Fibonacci_Large_Input();
            UIMap.Assert_Fibonacci_Large_Input();
        }

        [TestMethod]
        public void Fibonacci_Fibonacci_Input()
        {
            UIMap.Fibonacci_Fibonacci_Input();
            UIMap.Asser_Fibonacci_Fibonacci_Input();
        }

        [TestMethod]
        public void Fibonacci_Decimal_Input()
        {
            UIMap.Fibonacci_Decimal_Input();
            UIMap.Assert_Fibonacci_Decimal_Input();
        }

        [TestMethod]
        public void Fibonacci_Irrational_Input()
        {
            UIMap.Fibonacci_Irrational_Input();
            UIMap.Asser_Fibonacci_Irrational_Input();
           
        }

        [TestMethod]
        public void Fibonacci_Function_Input()
        {
            UIMap.Fibonacci_Function_Input();
            UIMap.Assert_Fibonacci_Function_Input();
        }

        [TestMethod]
        public void Fibonacci_ans_Input()
        {
            UIMap.Fibonacci_ans_Input();
            UIMap.Asser_Fibonacci_ans_Input();
        }

        [TestMethod]
        public void Fibonacci_UnderfinedVariable_Input()
        {
            UIMap.Fibonacci_UndefinedVariable_Input();
            UIMap.Asser_Fibonacci_UndefinedVariable_Input();
        }

        [TestMethod]
        public void Fibonacci_NULL_Input()
        {
            UIMap.Fibonacci_NULL_Input();
            UIMap.Asser_Fibonacci_NULL_Input();
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
    }
}