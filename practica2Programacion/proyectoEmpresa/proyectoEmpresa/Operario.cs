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
	/// Description of Operario.
	/// </summary>
	public class Operario:Empleado
	{
		protected int AnoServicio;
		protected string turno;
		public Operario():base(){
			AnoServicio= 5;
			turno = "mañana";
		}
		 public Operario(string nombre, string apellido, int ci, double sueldo, int AnoServicio, string turno) : base(nombre, apellido, ci, sueldo)
    	{
        	this.AnoServicio = AnoServicio;
        	this.turno = turno;
    	}
		public void Leer(){
			Console.WriteLine("\n--DATOS DE OPERARIO--");
			base.Leer();
			Console.Write("Ingrese sus Años de servicio: ");
			AnoServicio= int.Parse(Console.ReadLine());
			Console.Write("Ingrese su turno: ");
			turno = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("\n**Mostrando datos OPERARIO**");
			base.Mostrar();
			Console.WriteLine("Años de servicio: "+AnoServicio);
			Console.WriteLine("Turno: "+turno);
		}
	}
}
