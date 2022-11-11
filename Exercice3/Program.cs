 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(1, 3);
            Point B = new Point(1, 3);
        }
        public  class Point
        {
            int abscisse;
            int ordonné;

            public  Point (int x,int y)
            {
                abscisse = x;
                ordonné = y;
            }
            public void traslet(int dx , int dy)
            {
                abscisse += dx;
                ordonné += dy;
            }
            public double diseorigine( )

            {
                return Math.Sqrt(abscisse * abscisse + ordonné * ordonné);

            }
            public double distanceautre(Point B)
            {
                return Math.Sqrt((abscisse - B.abscisse )* (abscisse - B.abscisse)+(ordonné - B.ordonné)*(ordonné - B.ordonné) );
            }


        }

  
