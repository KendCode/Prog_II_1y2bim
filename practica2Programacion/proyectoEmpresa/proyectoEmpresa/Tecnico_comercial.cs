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
	/// Description of Tecnico_comercial.
	/// </summary>
	public class Tecnico_comercial:Empleado
	{
		protected string area;
		protected string sucursal_a_cargo;
		public Tecnico_comercial():base()
		{
			area = "area";
			sucursal_a_cargo = "SUCURSAL";
			
		}
		public Tecnico_comercial(string nombre, string apellido, int ci, double sueldo, string area, string sucursal_a_cargo, string turno) : base(nombre, apellido, ci, sueldo,turno)
    	{
        	this.area = area;
       		this.sucursal_a_cargo = sucursal_a_cargo;
    	}
		public void Leer(){
			Console.WriteLine("\n--Datos de tecnico comercial--");
			base.Leer();
			Console.Write("Ingrese el area de trabajo: ");
			area = Console.ReadLine();
			Console.Write("Ingrese el sucursal a cargo: ");
			sucursal_a_cargo = Console.ReadLine();
		}
		public void Mostrar(){
			Console.WriteLine("**DATOS DE TECNICO COMERCIAL**");
			base.Mostrar();
			Console.WriteLine("Area: "+area);
			Console.WriteLine("Sucursal a cargo: "+sucursal_a_cargo);
		}
		//B)
		public void VerTurno(string turnoOficial, Tecnico_en_piso tecnicoEnPiso){
			
    		if (turnoOficial == this.turno)
    		{
        		Console.WriteLine("El oficial está en el mismo turno que el técnico comercial.");
    		}
    		else
    		{
        		Console.WriteLine("El oficial no está en el mismo turno que el técnico comercial.");
    		}

    		if (tecnicoEnPiso.turno == this.turno)
    		{
        		Console.WriteLine("El técnico en piso está en el mismo turno que el técnico comercial.");
    		}
    		else
    		{
        		Console.WriteLine("El técnico en piso no está en el mismo turno que el técnico comercial.");
    		}
		}
	}
}
