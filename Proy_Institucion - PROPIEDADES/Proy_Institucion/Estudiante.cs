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
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante:Persona
	{
		protected string matricula;
		protected short cant_Materias;
		private Materia []Ma;
		
		public Estudiante(Materia m):base()
		{
			matricula = "12345";
	
			cant_Materias = 3;
			Ma = new Materia[cant_Materias];
			
			for(int i=0;i<cant_Materias;i++)
				Ma[i]= m;
		}
		public void Llenar(){
			Console.Write("\n--------DATOS DE ESTUDIANTE--------");
			base.Llenar();
			Console.Write("\nIngese matricula del estudiante: ");
			matricula = Console.ReadLine();
			Console.Write("\nIngrese cantidad de materias: ");
			cant_Materias =short.Parse(Console.ReadLine());
			for(int i=0;i<cant_Materias;i++)
				Ma[i].Llenar();
		}
		public void Mostrar(){
			Console.Write("\n          --------MOSTRANDO DATOS DE ESTUDIANTE--------");
			base.Mostrar();
			Console.Write("\nMatricula: "+matricula);
			Console.WriteLine("\nCantidad de materias: "+cant_Materias);
			for(int i=0;i<cant_Materias;i++)
				Ma[i].Mostrar();
		}
		
		//Get-Set nota 2
		public string getMatricula(){
			return matricula;
		}
		public void setMatricula(string matricula){
			this.matricula = matricula;
		}
		
		//Get-Set objeto Semestre
		public Materia[] getMATERIA(){
			return Ma;
		}
		public void setMATERIA(Materia[] Ma){
			this.Ma=Ma;
		}
		//c)2da forma
		public void mostrarNota3(int x){
			if(ci.Equals(x)){
				for(int i=0;i<cant_Materias;i++)
					Ma[i].mostrarNota2();
			}
		}
		//d)2da forma
		public void CorregirNota3(int x){
			if(ci.Equals(x)){
				for(int i=0;i<cant_Materias;i++)
					Ma[i].CorregirNota2();
			}
		}
		//f)2da forma
		public void buscarEstudiantes3(string y){
			
			for(int i=0;i<cant_Materias;i++)
				Ma[i].buscarEstudiantes2(y);
				Console.Write("\nMatricula del estudiante = "+matricula);
				Console.Write("\nNombre del estudiante = "+nombres);
		}
	}
}
