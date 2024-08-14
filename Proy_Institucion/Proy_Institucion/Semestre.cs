/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 20/6/2024
 * Time: 11:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proy_Institucion
{
	/// <summary>
	/// Description of Semestre.
	/// </summary>
	public class Semestre
	{
		private string periodo;
		private short cant_Catedraticos;
		private Catedratico[] Ca;
		
		private short cant_Estudiantes;
		private Estudiante[] Es;
		public Semestre(Catedratico cat,Estudiante est)
		{
			periodo = "QUINTO";
			
			cant_Catedraticos = 1;
			Ca = new Catedratico[cant_Catedraticos];
			for (int i=0; i<cant_Catedraticos;i++)
				Ca[i] = cat;
			
			cant_Estudiantes = 2;
			Es = new Estudiante[cant_Estudiantes];
			for (int i=0; i<cant_Estudiantes;i++)
				Es[i] = est;
			
		}
		public void Llenar(){
			Console.Write("\f--------DATOS DE SEMESTRE--------");
			Console.Write("\nIngrese periodo del semestre: ");
			periodo = Console.ReadLine();
			Console.Write("\nIngrese cantidad de catedraticos: ");
			cant_Catedraticos = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese cantidad de estudiantes: ");
			cant_Estudiantes = short.Parse(Console.ReadLine());
			
			for(int i=0;i<cant_Catedraticos;i++)
				Ca[i].Llenar();
			
			for(int i=0;i<cant_Estudiantes;i++)
				Es[i].Llenar();
			
		}
		public void Mostrar(){
			Console.Write("\n               --------MOSTRANDO DATOS DE SEMESTRE--------");
			Console.Write("\nPeriodo: "+periodo);
			Console.Write("\nCantidad de Catedraticos: "+cant_Catedraticos);
			Console.WriteLine("\nCantidad de Estudiantes: "+cant_Estudiantes);
			
			for(int i=0;i<cant_Catedraticos;i++)
				Ca[i].Mostrar();
			
			for(int i=0;i<cant_Estudiantes;i++)
				Es[i].Mostrar();
		}
		
		//Get-Set nombre 
		public string getPeriodo(){
			return periodo;
		}
		public void setPeriodo(string periodo){
			this.periodo = periodo;
		}
		
		//Get-Set cantidad Semestres
		public short getCantCatedraticos(){
			return cant_Catedraticos;
		}
		public void setCantCatedraticos(short cant_Catedraticos){
			this.cant_Catedraticos = cant_Catedraticos;
		}
		
		//Get-Set objeto catedratico
		public Catedratico[] getCATEDRATICO(){
			return Ca;
		}
		public void setCATEDRATICO(Catedratico[] Ca){
			this.Ca=Ca;
		}
		
		//Get-Set cantidad Semestres
		public short getCantEstudiantes(){
			return cant_Estudiantes;
		}
		public void setCantEstudiantes(short cant_Estudiantes){
			this.cant_Estudiantes = cant_Estudiantes;
		}
		
		//Get-Set objeto Semestre
		public Estudiante[] getESTUDIANTE(){
			return Es;
		}
		public void setESTUDIANTE(Estudiante[] Es){
			this.Es=Es;
		}
		
		//b)2da forma
		public int buscarNacionalidad2(string x,int cont_N){
			
			for(int i=0;i<cant_Estudiantes;i++)
				Es[i].buscarNacionalidad1(x);
				cont_N++;
			for(int i=0;i<cant_Catedraticos;i++)
				Ca[i].buscarNacionalidad1(x);
				cont_N++;
			return cont_N;
		}
		//c 2da forma
		public void mostrarNota4(){
			Console.Write("\nIngrese Ci de estudiante a buscar: ");
			int x =int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Estudiantes;i++)
				Es[i].mostrarNota3(x);
		}
		//d)2da forma
		public void CorregirNota4(){
			Console.Write("\nIngrese Ci de estudiante a buscar: ");
			int x =int.Parse(Console.ReadLine());
			for(int i=0;i<cant_Estudiantes;i++)
				Es[i].CorregirNota3(x);
		}
		//f)2da forma
		public void buscarEstudiantes4(){
			Console.Write("\nIngrese periodo: ");
			string x =Console.ReadLine();
			Console.Write("\nIngrese materia: ");
			string y = Console.ReadLine().ToLower();
			for(int i=0;i<cant_Estudiantes;i++){
				Es[i].buscarEstudiantes3(y);
				if(periodo.Equals(x)){
					Console.WriteLine();
				}
			}
		}
	}
}
