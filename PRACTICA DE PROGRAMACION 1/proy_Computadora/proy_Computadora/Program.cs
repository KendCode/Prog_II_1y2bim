/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 4/4/2024
 * Time: 14:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_Computadora
{
	class Program
	{
		public static void Main(string[] args)
		{
			Libro L1 = new Libro();
			L1.Leer();
			L1.Mostrar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}