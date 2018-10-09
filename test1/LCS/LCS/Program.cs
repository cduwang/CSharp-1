using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intList1 = { 34, 72, 13, 44, 25, 30, 10 };
            int[] intList2 = { 34, 13, 44, 7, 25 };

            string[] strList1 = { "abc", "def", "gh", "zwd" };
            string[] strList2 = { "abc", "2", "def", "gh", "zwd" };

            Rectangle[] recList1 = {
                new Rectangle(1.4, 2, UnitValues.m),new Rectangle(1.4, 2, UnitValues.m),
                new Rectangle(1, 2,UnitValues.m),new Rectangle(1.4, 2, UnitValues.m)
            };
            Rectangle[] recList2 = {
                new Rectangle(1.4, 2, UnitValues.m),new Rectangle(140, 200, UnitValues.cm),
                new Rectangle(1.4, 2,UnitValues.m),new Rectangle(1.4, 2, UnitValues.m)
            };

            Person[] personList1 =
            {
                new Person("zhang",31),new Person("wang",12)
            };
            Person[] personList2 =
            {
                new Person("wang",12)
            };

            LCS<int> intLCS = new LCS<int>(intList1, intList2);
            LCS<string> strLCS = new LCS<string>(strList1, strList2);
            LCS<Rectangle> recLCS = new LCS<Rectangle>(recList1, recList2);

            LCS<Person> personLCS = new LCS<Person>(personList1, personList2);

            intLCS.Demo();
            strLCS.Demo();
            recLCS.Demo();
            personLCS.Demo();


            Console.ReadLine();
        }
    }
}
