using System;

namespace NekoTool.Maths.Numbers
{
	/// <summary>
	/// The imaginary number.
	/// </summary>
	public struct Complex : IEquatable<Complex>, ICloneable
	{
		/// <summary>
		/// The real part
		/// </summary>
		public double x { get; }

		/// <summary>
		/// The imaginary part
		/// </summary>
		public double y { get; }

		/// <summary>
		/// The normal. The length.
		/// </summary>
		public double Normal { get; }

		/// <summary>
		/// Length. The normal. See <see cref="Normal"/>.
		/// </summary>
		public double Length => Normal;

		/// <summary>
		/// i
		/// </summary>
		public static readonly Complex i = new Complex(0, 1);

		/// <summary>
		/// Real to Complex
		/// </summary>
		/// <param name="n"></param>
		public Complex(double n)
		{
			x = n;
			y = 0;
			Normal = x;
		}

		/// <summary>
		/// x+yi.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public Complex(double a, double b)
		{
			x = a;
			y = b;
			Normal = CalcNorm(a, b);
		}

		public Complex(Complex other)
		{
			x = other.x;
			y = other.y;
			Normal = CalcNorm(x, y);
		}

		public static Complex operator +(Complex i)
			=> i;

		public static Complex operator +(Complex i1, Complex i2)
			=> new Complex(i1.x + i2.x, i1.y + i2.y);

		public static Complex operator +(Complex c, double d)
			=> new Complex(c.x + d, c.y);

		public static Complex operator +(double d, Complex c)
			=> new Complex(c.x + d, c.y);

		public static Complex operator -(Complex c)
			=> new Complex(-c.x, -c.y);

		public static Complex operator -(Complex i1, Complex i2)
			=> i1 + -i2;

		public static Complex operator -(Complex c, double d)
			=> c + -d;

		public static Complex operator -(double d, Complex c)
			=> d + -c;

		public static Complex operator *(double d, Complex i)
			=> new Complex(d * i.x, d * i.y);

		public static Complex operator *(Complex a, Complex b)
			=> new Complex(a.x * b.x - a.y * b.y, a.y * b.x + a.x * b.y);

		public static Complex operator *(Complex c, double d)
			=> new Complex(d * c.x, d * c.y);

		public static Complex operator /(Complex c, double d)
			=> new Complex(c.x / d, c.y / d);

		public static Complex operator /(double d, Complex i)
		{
			double m = Math.Pow(i.x, 2) + Math.Pow(i.y, 2);
			return new Complex(d * i.x / m, -d * i.y / m);
		}

		public static Complex operator /(Complex i1, Complex i2)
		{
			if (i2 == (Complex)0f) throw new ArithmeticException("Divide by 0");
			double m = Math.Pow(i2.x, 2) + Math.Pow(i2.y, 2);
			return new Complex((i1.x * i2.x + i1.y * i2.y) / m, (i1.y * i2.x - i1.x * i2.y) / m);
		}

		public static bool operator ==(Complex i1, Complex i2)
		{
			return i1.Equals(i2);
		}

		public static bool operator !=(Complex i1, Complex i2)
		{
			return !(i1 == i2);
		}

		/// <summary>
		/// Use the constructor to transform a double to an Complex.
		/// </summary>
		/// <param name="d"></param>
		public static explicit operator Complex(double d)
			=> new Complex(d);

		public static explicit operator double(Complex c) 
			=> c.x;

		public bool Equals(Complex other)
		{
			return x.Equals(other.x) && y.Equals(other.y);
		}

		public override bool Equals(object obj)
		{
			return obj is Complex other && Equals(other);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (x.GetHashCode() * 397) ^ y.GetHashCode();
			}
		}

		public object Clone()
		{
			return new Complex(this);
		}

		public override string ToString()
			=> x.ToString() + "+" + y.ToString() + "i";

		private static double CalcNorm(double x, double y)
		{
			return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
		}
	}
}
