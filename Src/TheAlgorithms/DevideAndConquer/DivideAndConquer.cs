/*
Given an array of n points. Findout the closed pair of points in the array.
*/
namespace TheAlgorithms.DevideAndConquer
{
    using System;
    using System.Linq;

    public class DivideAndConquer
    {
        public double Closest(Point[] p, int n)
        {
            Point[] sp = SortX(p);
            double d = ClosestInner(sp, sp.Length-1);

            return d;
        }

        private double ClosestInner(Point[] P, int n)
        {
            if (n < 3)
                return BrutForce(P, n);

            int mid = n / 2; // middle position
            Point midPoint = P[mid];

            // dl -> distence left | dr->distence right
            double dl = ClosestInner(P, mid);
            double dr = ClosestInner(P, n - mid);
            double d = Math.Min(dl, dr);

            // Build an array strip[] that contains  
            // points close (closer than d)  
            // to the line passing through the middle point 
            var strip = new Point[n];
            int j = 0;
            for(int i = 0; i < n; i++)
            {
                if (Math.Abs(P[i].X - midPoint.X) < d)
                {
                    strip[j] = P[i];
                    j++;
                }
            }
            double d2 = StripClosest(strip, j, d);

            return Math.Min(d, d2);
        }

        private double Dist(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        private Point[] SortX(Point[] points)
        {
            return points.OrderBy(item => item.X).ToArray(); ;
        }

        private Point[] SortY(Point[] points)
        {
            return points.OrderBy(item => item.Y).ToArray(); ;
        }

        private double StripClosest(Point[] strip, int size, double d)
        {
            double min = d; // Initialize the minimum distance as d
            Point[] sStrip = SortY(strip);

            // Pick all points one by one and try the next points till the difference  
            // between y coordinates is smaller than d.  
            // This is a proven fact that this loop runs at most 6 times  
            for (int i = 0; i < size; ++i)
            {
                for (int j = i + 1; j < size && (sStrip[j].Y - sStrip[i].Y) < min; ++j)
                {
                    if (Dist(sStrip[i], sStrip[j]) < min)
                    {
                        min = Dist(sStrip[i], sStrip[j]);
                    }
                }
            }

            return min;
        }

        private double BrutForce(Point[] P, int n)
        {
            double min = double.MaxValue;

            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (Dist(P[i], P[j]) < min)
                    {
                        min = Dist(P[i], P[j]);
                    }
                }
            }

            return min;
        }
    }

    public struct Point
    {
        public int X;
        public int Y;
    }
}
