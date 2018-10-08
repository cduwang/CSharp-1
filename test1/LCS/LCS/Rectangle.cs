using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    public enum UnitValues { mm, cm, dm, m }
    public class Rectangle
    {
        //长度
        double length;
        //宽度
        double width;
        //单位
        UnitValues unit;

        double area_mm
        {
            get
            {
                return Val2mm(width) * Val2mm(length);
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="length">长度</param>
        /// <param name="width">宽度</param>
        /// <param name="unit">单位</param>
        public Rectangle(double length, double width, UnitValues unit)
        {
            this.length = length;
            this.width = width;
            this.unit = unit;
        }

        public override string ToString()
        {
            string str = $"{length}{unit}*{width}{unit}={area_mm}{UnitValues.mm}2";
            return str;
        }
        public double Val2mm(double u)
        {
            switch (unit)
            {
                case UnitValues.mm:
                    return u;
                case UnitValues.cm:
                    return 10.0 * u;
                case UnitValues.dm:
                    return 100.0 * u;
                case UnitValues.m:
                    return 1000.0 * u;
                default:
                    return -1;
            }
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
            //面积相等就认为相等
            if (area_mm!=a2.area_mm)
                return false;
            else
                return true;
        }

        public override int GetHashCode()
        {
            return (int)length;
        }
    }
}
