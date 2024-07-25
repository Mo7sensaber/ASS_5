using System.Drawing;

namespace ASS_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firest project

            #region 1
            point p1 = new point(10, 10, 10);

            #endregion

            #region 2
            Console.WriteLine(p1);
            #endregion

            #region 3
            int x;
            int y;
            int z;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);
            point p2 = new point(x, y, z);
            Console.WriteLine(p2);
            #endregion

            #region 4
            if (p1 == p2)
                Console.WriteLine("is equal");
            else Console.WriteLine("is not equal");
            #endregion

            #region 5
            //Point[] points = new Point[]
            //{
            //    new Point(1, 2, 3),
            //    new Point(4, 1, 6),
            //    new Point(2, 3, 5),
            //    new Point(2, 1, 4),
            //    new Point(3, 3, 3)
            //};

            //// Sort the array based on X and Y coordinates
            //Array.Sort(points, (p1, p2) =>
            //{
            //    int result = p1.X.CompareTo(p2.X);
            //    return result == 0 ? p1.Y.CompareTo(p2.Y) : result;
            //}); 
            #endregion 
            #endregion

            #region Second Project
            point p3 = new point();
            p3 = p1 + p2;
            Console.WriteLine(p3);
            p3 = p1 - p2;
            Console.WriteLine(p3);
            p3 = p1 * p2;
            Console.WriteLine(p3);
            p3 = p1 / p2;
            Console.WriteLine(p3);
            #endregion

            #region Therd project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString()); 
            #endregion
        }
    }
}