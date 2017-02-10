using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace UnitTestCalculatorMy
{
    [TestClass]
    public class UnitTestOutputer
    {
        // private variables
        private Calculator calculator_for_test; // reference on trash
      

        [TestInitialize]
        public void TestInitialize() {

            // create calculator instanse
            //Calculator calculator_for_test = new Calculator(); local

            this.calculator_for_test   = new Calculator(); // this.calculator_for_test   reference on real data

            Debug.WriteLine("Calculator created");


        }

        // final action after test
        [TestCleanup]
        public void TestCleanup() {

            Debug.WriteLine("All test finished");
           // this.calculator_for_test.Dispose(); error in calculator cannot free memory
        }


        [TestMethod]
        public void TestSum()
        {
            float x = 4;
            float y = 5;

            float expected_result = 9;

            float real_result = x + y;


            Assert.AreEqual(expected_result, real_result, "Sum is tested");

            Debug.WriteLine("Sum test is finished");
        }

        [TestMethod]
        public void TestSub()
        {
            float x = 4;
            float y = 5;

            float expected_result = -1;

            float real_result = x - y;


            Assert.AreEqual(expected_result, real_result, "Dub is tested");
            Debug.WriteLine("Sub test is finished");
        }

        //test string------------------------------------------

        //StringAssert

        [TestMethod]
        public void TestStringContainSubstring()
        {
            string str_1 = "Hello Mike";

            string str_2 = "Hello Miike";
            // contains substring
            StringAssert.Contains(str_1, "kes");
        }

        [TestMethod]
        public void TestStringEquals()
        {
            string str_1 = "Hello aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
            // ok if equal types
            StringAssert.Equals(str_1, str_2);

            //ok if correct regular expression

            StringAssert.Matches(str_1, new Regex("(a){3}(b){3}(\\d){3}"));
        }


        [TestMethod]
        public void TestStringStartWith()
        {

            string str_1 = "Hell1o aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
           
   

            StringAssert.StartsWith(str_1, "Hello");
        }

        [TestMethod]
        public void TestStringEndWith()
        {

            string str_1 = "Hell1o aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
    

            StringAssert.EndsWith(str_1, "Mike");
        }

        //Test collection -------------------------------

        [TestMethod]
        public void TestCollection()
        {
            List<string> List_of_str = new List<string>();

            List_of_str.Add("Ivanov");
            List_of_str.Add("Petriv");
            List_of_str.Add("asdfhda");
            string x = "some text";

            CollectionAssert.AllItemsAreInstancesOfType(List_of_str, x.GetType());
        }


        [TestMethod]
        public void TestCollectionClass()
        {
            List<object> List_of_obj = new List<object>();

            List_of_obj.Add("Ivanov");
            List_of_obj.Add("Petriv");
            List_of_obj.Add("asdfhda");
            List_of_obj.Add(123);

            string x = "some text";



            CollectionAssert.AllItemsAreInstancesOfType(List_of_obj, x.GetType());
        }

        [TestMethod]
        public void TestCollectionMyElements()
        {
            List<My_Element> List_of_obj = new List<My_Element>();

            My_Element element_1 = new My_Element();
            My_Element element_2 = new My_Element();
            My_Element element_3 = new My_Element();

            List_of_obj.Add(element_1);
            List_of_obj.Add(element_2);
            List_of_obj.Add(element_3);



            CollectionAssert.AllItemsAreInstancesOfType(List_of_obj, element_1.GetType());
        }

        [TestMethod]
        public void TestCollectionMyElementsExist()
        {
            List<My_Element> List_of_obj = new List<My_Element>();

            My_Element element_1 = new My_Element();
            My_Element element_2 = new My_Element();
            My_Element element_3 = new My_Element();

            My_Element element_4 = null;

            List_of_obj.Add(element_1);
            List_of_obj.Add(element_2);
            List_of_obj.Add(element_3);
            List_of_obj.Add(element_4);




            CollectionAssert.AllItemsAreNotNull(List_of_obj);
        }

        [TestMethod]
        public void TestCollectionUniqu()
        {
            List<string> List_of_str = new List<string>();

            List_of_str.Add("Ivanov");
            List_of_str.Add("Petriv");
            List_of_str.Add("ivanov");


            CollectionAssert.AllItemsAreUnique(List_of_str);
        }

        [TestMethod]
        public void TestCollectionEqualTo()
        {
            List<string> List_of_str = new List<string>();

            List_of_str.Add("Ivanov");
            List_of_str.Add("Petriv");
            List_of_str.Add("ivanov");
            List_of_str.Add("Adfjd");
            List<string> List_of_str_exp = new List<string>();

            List_of_str_exp.Add("Ivanov");
            List_of_str_exp.Add("Petriv");
            List_of_str_exp.Add("ivanov");
            List_of_str_exp.Add("Adfjd");

            CollectionAssert.AreEquivalent(List_of_str,List_of_str_exp);
        }

        [TestMethod]
        public void TestCollectionEqualToOrder()
        {
            List<string> List_of_str = new List<string>();


            List_of_str.Add("Adfjd");
            List_of_str.Add("Ivanov");
            List_of_str.Add("Petriv");
            List_of_str.Add("ivanov");
            
            List<string> List_of_str_exp = new List<string>();

            List_of_str_exp.Add("Ivanov");
            List_of_str_exp.Add("Petriv");
            List_of_str_exp.Add("ivanov");
            List_of_str_exp.Add("Adfjd");

            CollectionAssert.AreEqual(List_of_str, List_of_str_exp);
        }
        [TestMethod]
        public void TestCollectionSubSet()
        {
            List<string> List_of_str = new List<string>();


            List_of_str.Add("Adfjd");
            List_of_str.Add("Ivanov");
            List_of_str.Add("Petriv");
            List_of_str.Add("ivanov");
            List_of_str.Add("audfiad");

            List<string> List_of_str_sub = new List<string>();

            List_of_str_sub.Add("Ivanov");
            List_of_str_sub.Add("Petriv");
            List_of_str_sub.Add("ivanov");
            List_of_str_sub.Add("Adasdffjd");

            CollectionAssert.IsSubsetOf(List_of_str_sub,List_of_str);
        }
    }
}
