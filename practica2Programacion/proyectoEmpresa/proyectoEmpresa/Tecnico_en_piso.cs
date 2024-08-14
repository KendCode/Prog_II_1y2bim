/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 17/4/2024
 * Time: 23:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoEmpresa
{
	/// <summary>
	/// Description of Tecnico_en_piso.
	/// </summary>
	public class Tecnico_en_piso:Empleado
	{
		protected string tipo;
		public Tecnico_en_piso()
		{
		}
		public Tecnico_en_piso(string nombre, string apellido, int ci, double sueldo, string tipo) : base(nombre, apellido, ci, sueldo)
    	{
        	this.tipo = tipo;
   	 	}
		public void Leer(){
			Console.WriteLine("\n--DATOS DE TECNICO EN PISO");
			base.Leer();
			Console.Write("Ingrese el tipo: ");
			tipo = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("MOSTANDO DATOS DE TECNICO DE PISO");
			base.Mostrar();
			Console.WriteLine("Tipo: "+tipo);
		}
	}
}
