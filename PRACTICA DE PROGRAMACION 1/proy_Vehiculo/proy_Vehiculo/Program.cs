/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 4/4/2024
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_Vehiculo
{
	class Program
	{
		public static void Main(string[] args)
		{
			vehiculo V1 = new vehiculo();
			V1++;
			vehiculo V2 = new vehiculo();
			V2++;
			
			/*vehiculo V2 = new vehiculo("QWE123", 14785, "ZXC156", "AMARILLO", "FORD"); V2--;
			vehiculo V3 = new vehiculo("BMW", "ROJO", "REE122", 10201, "BOE258"); V3--;
			vehiculo V4 = new vehiculo(987654, "XBX987", "MERCEDES", "VERDE", "GGG852"); V4--;
			vehiculo V5 = new vehiculo("BLANCO","OPEL"); V5--;*/
			
			Console.WriteLine("\n-- Concatenación de vehículos --");
        	vehiculo R = V1 + V2;

        	Console.WriteLine("\nDatos del vehículo resultante:");
        	
       		R.Mostrar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}