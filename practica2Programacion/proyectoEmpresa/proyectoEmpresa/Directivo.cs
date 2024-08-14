/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 17/4/2024
 * Time: 23:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoEmpresa
{
	/// <summary>
	/// Description of Directivo.
	/// </summary>
	public class Directivo:Empleado
	{
		protected string cargo;
		protected int nro_oficina;
		public Directivo():base()
		{
			cargo = "gerente";
			nro_oficina = 15;
		}
		public Directivo(string nombre, string apellido, int ci, double sueldo, string cargo, int nro_oficina):base(nombre, apellido, ci, sueldo){
			this.cargo = cargo;
			this.nro_oficina = nro_oficina;	
		}
		public void Leer(){
			Console.WriteLine("\n--DATOS DE DIRECTIVO--");
			base.Leer();
			Console.Write("Ingrese su Cargo: ");
			cargo = Console.ReadLine();
			Console.Write("Ingrese su Nro de Oficina: ");
			nro_oficina = int.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			Console.WriteLine("**MOSTRANDO DATOS DE DIRECTIVO**");
			base.Mostrar();
			Console.WriteLine("Cargo: "+cargo);
			Console.WriteLine("Nro de Oficina: "+nro_oficina);
		
		}
	}
}
