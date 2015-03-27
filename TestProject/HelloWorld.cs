using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	class HelloWorld
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class InheritedRandomGeneric : RandomGenericClass<String, int, float> { }

	public class RandomGenericClass<TName, TIndex, TType>
	{
		internal RandomGenericClass()
		{
			Console.WriteLine(" I am constructing. ");
		}

		/// <summary>
		/// Documentation for Overload int.
		/// </summary>
		/// <param name="overload">The parameter.</param>
		/// <returns>The return.</returns>
		public int[] OverloadedMethod(int[] overload)
		{
			return overload;
		}

		/// <summary>
		/// Documentation for Overload single.
		/// </summary>
		/// <param name="overload">The parameter.</param>
		/// <returns>The return.</returns>
		public Single[] OverloadedMethod(Single[] overload)
		{
			return overload;
		}

		/// <summary>
		/// Documentation for Overload double.
		/// </summary>
		/// <param name="overload">The parameter.</param>
		/// <returns>The return</returns>
		public double[] OverloadedMethod(double[] overload)
		{
			return overload;
		}

	}
}
