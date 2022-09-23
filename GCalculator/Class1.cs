using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCalculator
{
    public class Class1
    {
        public double GetTriangle(float a, float b, float c)// радиус треугольника
        {
			try
			{
                float p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			}
			catch
			{
                return 0f;
			}
        }
		public bool IsStraight(float a, float b, float c)// проверка треугольника, явялется ли прямоугольным
		{
			if (a > b && a > c)
				if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
					return true;

			if (b > a && b > c)
				if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
					return true;

			if (c > b && c > a)
				if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
					return true;

			return false;
		}
		public double GetCircle(float r)// радиус круга
		{
			try
			{
				return 3.1415 * Math.Pow(r, 2);
			}
			catch 
			{
				return 0f;
			}
		}
    }
}
