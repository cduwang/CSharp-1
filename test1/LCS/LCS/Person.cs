using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class Person
    {
        //成员变量首字母大写
        string Name;
        int Age;
        //构造函数
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            string str = $"姓名：{Name}，年龄：{Age}";
            return str;
        }
        public static bool operator != (Person a1, Person a2)
        {

            if ((a1 as object) != null)
                return !a1.Equals(a2);
            else
                return (a2 as object) != null;
        }

        public static bool operator ==(Person a1, Person a2)
        {
            if ((a1 as object) != null)
                return a1.Equals(a2);
            else
                return (a2 as object) == null;
        }
        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Settings return false.
            Person a2 = obj as Person;
            if ((System.Object)a2 == null)
            {
                return false;
            }
            // Return true if the fields match:
            //name和age都相等才相等
            //if (area_mm != a2.area_mm)
            if (Age != a2.Age || Name != a2.Name)
                return false; //不相等
            else
                return true;//相等
        }

    }
}
