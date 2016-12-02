using System;

namespace xr1_2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// 数値リテラルでもオブジェクト型のメソッドが利用可能
			Console.WriteLine(123.GetType());

			bool a = true;
			Console.WriteLine("a = {0}", a.GetType());

			int b = -123;
			Console.WriteLine("b = {0}", b.GetType());

			double c = 4.56e10;
			Console.WriteLine("c = {0}", c.GetType());

			string msg = "Hello";
			Console.WriteLine("msg = {0}", msg.GetType());

			//bool noInit;
			//// 値が格納されていないのに参照しようとしたため、コンパイルラー
			//Console.WriteLine("noInit = {0}", noInit.GetType());

		}
	}
}
