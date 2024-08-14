/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 17/4/2024
 * Time: 23:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoEmpresa
{
	/// <summary>
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		protected string nombre;
		protected string apellido;
		protected int ci;
		protected double sueldo;
		public Empleado()
		{
			nombre = "rodrigo";
			apellido = "vasquez";
			ci = 123456;
			sueldo = 2440.80;
		}
		public Empleado(string nombre, string apellido, int ci, double sueldo){
			this.nombre = nombre;
			this.apellido = apellido;
			this.ci = ci;
			this.sueldo = sueldo;
		}
		public void Leer(){
			Console.WriteLine("--DATOS DE EMPLEADO--");
			Console.Write("Ingrese su nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Ingrese su apellido: ");
			apellido = Console.ReadLine();
			Console.Write("Ingrese su CI: ");
			ci = int.Parse(Console.ReadLine());
			Console.Write("Ingrese su CI");
			sueldo = double.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("Nombre: "+nombre);
			Console.WriteLine("Apellido: "+apellido);
			Console.WriteLine("CI: "+ci);
			Console.WriteLine("Sueldo: "+sueldo);
		}
	}
}
