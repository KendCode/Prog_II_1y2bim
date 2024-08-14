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
	/// Description of Oficial.
	/// </summary>
	public class Oficial:Operario
	{
		protected string grado;
		public Oficial():base()
		{
		}
		public Oficial(string nombre, string apellido, int ci, double sueldo, int AnoServicio, string turno, string grado) : base(nombre, apellido, ci, sueldo, AnoServicio, turno)
    	{
        	this.grado = grado;
    	}
		public void Leer(){
			Console.WriteLine("\n--DATOS DE OFICIAL--");
			base.Leer();
			Console.Write("Ingrese su grado: ");
			grado = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("**MOSTRANDO DATOS DE OFICIAL**");
			base.Mostrar();
			Console.WriteLine("Grado: "+grado);
				
		}
	}
}
