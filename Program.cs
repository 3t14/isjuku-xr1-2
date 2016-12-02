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

			// decimal型
			// 10進数値で格納する変数型
			decimal d = 10;
			Console.WriteLine("d = {0}", d.GetType());
			d = 10.1234m;
			Console.WriteLine("d = {0}", d.GetType());
			
			// decimal型おリテラルはmもしくはMを付与しなければならないため
			// 下記はコンパイルエラーとなる。
			// d = 1.234;

			// object型
			object obj;
			obj = 1; // System.Int32
			Console.WriteLine("obj = {0}", obj.GetType());
			// System.String すべてのクラスの派生元であるため
			// 動的に異なるデータ型を割りあてることが可能
			obj = "ほげ"; 
			Console.WriteLine("obj = {0}", obj.GetType());

		}
	}
}
