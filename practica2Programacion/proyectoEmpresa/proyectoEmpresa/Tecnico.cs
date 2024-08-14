/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 17/4/2024
 * Time: 23:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoEmpresa
{
	/// <summary>
	/// Description of Tecnico.
	/// </summary>
	public class Tecnico:Empleado
	{
		protected string especialidad;
		public Tecnico()
		{
			especialidad = "electrico";
		}
		public Tecnico(string nombre, string apellido, int ci, double sueldo, string especialidad) : base(nombre, apellido, ci, sueldo)
    	{
        	this.especialidad = especialidad;
    	}
		public void Leer(){
			Console.WriteLine("\n--DATOS TECNICO--");
			base.Leer();
			Console.Write("Ingrese la especialidad: ");
			especialidad = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("**DATOS DE TECNICO**");
			base.Mostrar();
			Console.WriteLine("Especialidad: "+especialidad);
		}
	}
}
