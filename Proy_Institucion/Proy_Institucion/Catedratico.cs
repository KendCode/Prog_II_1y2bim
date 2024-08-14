/*
 * Creado por SharpDevelop.
 * Usuario: MIKE
 * Fecha: 15/6/2024
 * Hora: 21:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Institucion
{
	/// <summary>
	/// Description of Catedraticos.
	/// </summary>
	public class Catedratico:Persona
	{
		protected string cod_Catedratico;
		protected int item;
		protected double sueldo;
		public Catedratico():base()
		{
			cod_Catedratico = "YYY888";
			item = 321;
			sueldo = 5000;
		}
		public void Llenar(){
			base.Llenar();
			Console.Write("\n--------DATOS DE CATEDRATICO--------");
			Console.Write("\nIngrese codigo de catedratico: ");
			cod_Catedratico = Console.ReadLine();
			Console.Write("\nIngrese item del catedratico: ");
			item = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese sueldo del catedratico: ");
			sueldo = double.Parse(Console.ReadLine());
		}
		public void Mostrar(){
			
			Console.Write("\n--------MOSTRANDO DATOS DE CATEDRATICO--------");
			Console.Write("\nCodigo de Catedratico: "+cod_Catedratico);
			Console.Write("\nitem de Catedratico: "+item);
			Console.WriteLine("\nsueldo de Catedratico: "+sueldo);
			base.Mostrar();
		}
		
		//Get-Set nota 2
		public string getCod_Catedraticos(){
			return cod_Catedratico;
		}
		public void setCod_Catedraticos(string cod_Catedratico){
			this.cod_Catedratico = cod_Catedratico;
		}
		
		//Get-Set Item
		public int getItem(){
			return item;
		}
		public void setItem(short item){
			this.item = item;
		}
		
		//Get-Set sueldo
		public double getSueldo(){
			return sueldo;
		}
		public void setSueldo(double sueldo){
			this.sueldo = sueldo;
		}
	}
}
