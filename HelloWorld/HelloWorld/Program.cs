using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace RectangleApplication
{
    class Rectangle
    {
        // 成员变量
        /// <summary>
        /// </summary>
        double length;
        double width;

        double length_mm
        {
            get
            {
                return Val2mm(length);
            }
        }
        double width_mm
        {
            get
            {
                return Val2mm(width);
            }
        }
        /// <summary>
        /// 矩形的长度单位
        /// </summary>
        string unit;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
            unit = "mm";
        }
        /// <summary>
        /// 接受外部参数输入
        /// </summary>
        /// <param name="length">长度</param>
        /// <param name="width">宽度</param>
        /// <param name="unit">单位</param>
        public void Acceptdetails(double length, double width, string unit)
        {
            this.length = length;
            this.width = width;
            this.unit = unit;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}{1}", length, unit);
            Console.WriteLine("Width: {0}{1}", width, unit);
            Console.WriteLine("Area: {0}{1}2", GetArea(), unit);
        }

        public double Val2mm(double u)
        {
            if (unit == "mm")
                return u;
            else if (unit == "cm")
                return 10.0 * u;
            else if (unit == "dm")
                return 100.0 * u;
            else if (unit == "m")
                return 1000.0 * u;
            return -1;
        }
        public static bool operator !=(Rectangle a1, Rectangle a2)
        {

            if ((a1 as object) != null)
                return !a1.Equals(a2);

            else

                return (a2 as object) != null;
        }

        public static bool operator ==(Rectangle a1, Rectangle a2)
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
            Rectangle a2 = obj as Rectangle;
            if ((System.Object)a2 == null)
            {
                return false;
            }


                // Return true if the fields match:
                // lenght => this.length
                if (length_mm != a2.length_mm ||
                    width_mm != a2.width_mm)
                return false;
            else
                return true;
        }

        public override int GetHashCode()
        {
            return (int)length;
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();//新增房间1，r1是房间1的钥匙
            Rectangle r2 = new Rectangle();//新增房间2，r2是房间2的钥匙
            //Rectangle r3 = r1;//r3是房间1的钥匙

            r1.Acceptdetails(1.4, 2, "m");
            r2.Acceptdetails(1400, 2000, "mm");

            r1.Display();
            r2.Display();


            if (r1 == r2)
                Console.WriteLine("===================");
            else
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!");

            Console.ReadLine();
        }
    }
}
