
/// Homework No.__ Exercise No.__
/// File Name:     HW7-2.sln
/// @author:       Upendra Samaranayake
/// Date:          Oct. 27, 2019
///
/// Problem Statement: Write a Temperature class with two instance bvariables.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create Temperature class with the requisite methods as instructed.

///
using System;

namespace Homework7P2
{
    class Program
    {
		public static void Main(string[] args)
		{

			Temperature temp = new Temperature();
			Console.WriteLine(temp.ToString());

			Temperature temp1 = new Temperature(-40, 'c');
			Console.WriteLine(temp1.ToString());

			Temperature temp2 = new Temperature(100, 'c');
			Console.WriteLine(temp2.ToString());

		}
		public class Temperature
		{
			private float degree = 0;
			private char scale = 'c';

			internal Temperature(float degree)
			{
				this.degree = degree;
			}

			internal Temperature(char scale)
			{
				this.scale = scale;
			}

			internal Temperature(float degree, char scale)
			{
				this.degree = degree;
				this.scale = scale;
			}

			internal Temperature()
			{
			}

			public virtual float DegreeC
			{
				get
				{
					return (5 * (degree - 32) / 9);
				}
			}

			public virtual float DegreeF
			{
				get
				{
					return ((9 * (degree) / 5) + 32);
				}
			}

			public virtual float Degree
			{
				set
				{
					this.degree = value;
				}
			}

			public virtual char Scale
			{
				get
				{
					return scale;
				}
			}

			public virtual char ScaleC
			{
				set
				{
					this.scale = 'c';
				}
			}

			public virtual char ScaleF
			{
				set
				{
					this.scale = 'f';
				}
			}

			public virtual void setScale(char scale1, char scale2)
			{
				this.scale = 'c';
				this.scale = 'f';
			}

			public virtual bool isEqual(float temp1, float temp2)
			{
				if (temp1 == temp2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public virtual bool isGreater(float temp1, float temp2)
			{
				if (temp1 > temp2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public virtual bool isLess(float temp1, float temp2)
			{
				if (temp1 < temp2)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public override string ToString()
			{
				if (scale == 'f')
				{
					return "Fahrenheit to Celcius is: " + DegreeC;
				}
				else
				{
					return "Celcius to Fahrenheit is: " + DegreeF;
				}

			}
		}

	}
}
