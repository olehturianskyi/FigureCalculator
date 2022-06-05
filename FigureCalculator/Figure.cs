using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculator
{
    internal class Figure
    {
        Point _A;
        Point _B;
        Point _C;
        Point _D;
        Point _E;

        public Figure(Point A, Point B, Point C)
        {
            this._A = A; 
            this._B = B; 
            this._C = C;
        }
        public Figure(Point A, Point B, Point C, Point D) : this(A, B, C)
        {
            this._D = D;           
        }
        public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
        {            
            this._E = E;
        }
        public double LengthSide(Point A, Point B)
        {            
            double length = Math.Sqrt(Math.Pow(B.GetX - A.GetX, 2) + Math.Pow(B.GetY - A.GetY, 2));
            return length;
        }
        public void PerimeterCalculator()
        {
            if (_A != null && _B != null && _C != null && _D == null && _E == null)
            {
                double ab_lenqth = LengthSide(this._A, this._B);
                double bc_lenqth = LengthSide(this._B, this._C);
                double ca_lenqth = LengthSide(this._C, this._A);
                Console.WriteLine("Side length AB: " + ab_lenqth);
                Console.WriteLine("Side length BC: " + bc_lenqth);
                Console.WriteLine("Side length CA: " + ca_lenqth);
                double perimeter = ab_lenqth + bc_lenqth + ca_lenqth;
                Console.WriteLine("Perimeter: " + Convert.ToString(perimeter));
            }
            if (_A != null && _B != null && _C != null && _D != null && _E == null)
            {
                double ab_lenqth = LengthSide(this._A, this._B);
                double bc_lenqth = LengthSide(this._B, this._C);
                double cd_length = LengthSide(this._C, this._D);
                double da_length = LengthSide(this._D, this._A);
                Console.WriteLine("Side length AB: " + ab_lenqth);
                Console.WriteLine("Side length BC: " + bc_lenqth);
                Console.WriteLine("Side length CD: " + cd_length);
                Console.WriteLine("Side length DA: " + da_length);
                double perimeter = ab_lenqth + bc_lenqth + cd_length + da_length;
                Console.WriteLine("Perimeter: " + Convert.ToString(perimeter));
            }
            if (_A != null && _B != null && _C != null && _D != null && _E != null)
            {
                double ab_lenqth = LengthSide(this._A, this._B);
                double bc_lenqth = LengthSide(this._B, this._C);
                double cd_length = LengthSide(this._C, this._D);
                double de_length = LengthSide(this._D, this._E);
                double ea_length = LengthSide(this._E, this._A);
                Console.WriteLine("Side length AB: " + ab_lenqth);
                Console.WriteLine("Side length BC: " + bc_lenqth);
                Console.WriteLine("Side length CD: " + cd_length);
                Console.WriteLine("Side length DE: " + de_length);
                Console.WriteLine("Side length EA: " + ea_length);
                double perimeter = ab_lenqth + bc_lenqth + cd_length + de_length + ea_length;
                Console.WriteLine("Perimeter: " + Convert.ToString(perimeter));
            }
        }
    }
}
