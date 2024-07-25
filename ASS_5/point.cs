using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_5
{
    internal class point
    {
        public int x;
        public int y;
        public int z;

        public point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public point()
        {
            
        }
        public static bool operator ==(point point1,point point2)
            {
            if (point1.x == point2.x && point1.y == point2.y && point1.z == point2.z )
                return true;
            return false;
            }
        public static bool operator !=(point point1, point point2)
        {
            return !(point1 == point2);
        }
        public static point operator +(point point1, point point2)
        {
            point result=new point(0,0,0);
            result.x = point1.x + point2.x;
            result.y = point1.y + point2.y;
            result.z = point1.z + point2.z;
            return result;
        }
        public static point operator -(point point1, point point2)
        {
            point result = new point(0, 0, 0);
            result.x = point1.x - point2.x;
            result.y = point1.y - point2.y;
            result.z = point1.z - point2.z;
            return result;
        }
        public static point operator *(point point1, point point2)
        {
            point result = new point(0, 0, 0);
            result.x = point1.x * point2.x;
            result.y = point1.y * point2.y;
            result.z = point1.z * point2.z;
            return result;
        }
        public static point operator /(point point1, point point2)
        {
            point result = new point(0, 0, 0);
            result.x = point1.x / point2.x;
            result.y = point1.y / point2.y;
            result.z = point1.z / point2.z;
            return result;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
    }
}
