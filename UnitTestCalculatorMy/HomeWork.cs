using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace UnitTestCalculatorMy
{
    [TestClass]
    public class HomeWork
    {
        [TestMethod]
        public void HomeWorkdata()
        {

            My_Element element_1 = new My_Element();
            element_1.data = -12;
            element_1.phone_number = "097-12-12";
            element_1.info = "Hello Mike";


            My_Element element_2 = new My_Element();

            element_2.data = 122;
            element_2.phone_number = "091-12-32";
            element_2.info = "Hello Joe";


            My_Element element_3 = new My_Element();

            element_3.data = 12212341;
            element_3.phone_number = "044-12-32";
            element_3.info = "Hello Abrasha";

            Boolean x = element_1.data > 0 && element_1.data <100;
            Boolean y = true;

            List<Object> my_super_list = new List<object>();

            my_super_list.Add(24);
            my_super_list.Add(null);
            my_super_list.Add(element_1);
            my_super_list.Add("Hello");
            my_super_list.Add(element_2);


            //phone 050 097 operators?
            //in info Hello....
            // data>0 and data <100
            //all element was not null and unique


            StringAssert.StartsWith(element_1.info, "Hello");
            Assert.AreEqual(y, x);
            StringAssert.Matches(element_1.phone_number, new Regex("^(050|097)-(\\d){2}-(\\d){2}") );
            CollectionAssert.AllItemsAreNotNull(my_super_list);
            CollectionAssert.AllItemsAreUnique(my_super_list);

        }
    }
}
