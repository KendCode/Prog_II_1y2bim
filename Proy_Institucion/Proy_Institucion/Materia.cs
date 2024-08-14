/*
 * Creado por SharpDevelop.
 * Usuario: MIKE
 * Fecha: 15/6/2024
 * Hora: 21:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Institucion
{
	/// <summary>
	/// Description of Materia.
	/// </summary>
	public class Materia
	{
		private string nombre;
		private string sigla;
		private Nota No = new Nota();
		public Materia()
		{
			nombre = "Estadistica";
			sigla = "EST";
		}
		public void Llenar(){
			Console.Write("\n--------DATOS DE MATERIA--------");
			Console.Write("\nIngrese nombre de la materia: ");
			nombre = Console.ReadLine();
			Console.Write("\nIngrese una sigla de la materia");
			sigla = Console.ReadLine();
			No.Llenar();
		}
		public void Mostrar(){
			Console.Write("\n--------MOSTRANDO DATOS DE MATERIA--------");
			Console.Write("\nNombre: "+nombre);
			Console.WriteLine("\nSigla: "+sigla);
			No.Mostrar();
		}
		//Get-Set NOMBRE
		public string getNombre(){
			return nombre;
		}
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		
		//Get-Set SIGLA
		public string getSigla(){
			return sigla;
		}
		public void setSigla(string sigla){
			this.sigla = sigla;
		}
		
		//Get-Set NOTA
		public Nota getNota(){
			return No;
		}
		public void setNota(Nota No){
			this.No = No;
		}
		//c)2da forma
		public void mostrarNota2(){
			Console.Write("\nIngrese materia: ");
			string y=Console.ReadLine();
			if(nombre.ToLower().Equals(y)){
				No.mostrarNota1();
			}
		}
		//d)2da forma
		public void CorregirNota2(){
			No.CorregirNota1();
		}
		//f)2da forma
		public void buscarEstudiantes2(string y){
			
			if(nombre.ToLower().Equals(y)){
				No.buscarEstudiantes1();
			}
		}
	}
}
