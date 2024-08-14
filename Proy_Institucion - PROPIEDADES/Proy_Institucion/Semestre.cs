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
		public string Periodo{
			get{return periodo;}
			set{periodo=value;}
		}
		public short CantCate{
			get{return cant_Catedraticos;}
			set{cant_Catedraticos=value;}
		}
		public Catedratico[] CATEDRATICO{
			get{return Ca;}
			set{Ca=value;}
		}
		public short CantEst{
			get{return cant_Estudiantes;}
			set{cant_Estudiantes=value;}
		}
		public Estudiante[] ESTUDIANTE{
			get{return Es;}
			set{Es=value;}
		}
		
		
	}
}
