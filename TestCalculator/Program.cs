using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create collection
            List<My_Element> my_list = new List<My_Element>();

            My_Element element_1 = new My_Element();
            My_Element element_2 = new My_Element();
            My_Element element_3 = new My_Element();

            element_1.info = "Elemet1";
            element_2.info = "Elemet2";
            element_3.info = "Elemet3";

            my_list.Add(element_1);
            my_list.Add(element_2);

            //iterators
            //foreach(type_var var_name in list_name)

            foreach(My_Element current in my_list)
            {
                Console.WriteLine(current.info);
            }

            my_list.Remove(element_2);
            Console.WriteLine("After remove");
            foreach (My_Element current in my_list)
            {
                Console.WriteLine(current.info);
            }
            my_list.Clear();
            Console.ReadKey();
        }
    }
}
