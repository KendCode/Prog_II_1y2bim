/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 17/4/2024
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyectoEmpresa
{
	class Program
	{
		public static void Main(string[] args)
		{
			Empleado E = new Empleado();
			E.Mostrar();
			
			Operario OP = new Operario();
			OP.Mostrar();
			
			Directivo D = new Directivo();
			D.Mostrar();
			
			Oficial OF = new Oficial();
			OF.Mostrar();
			
			Tecnico T = new Tecnico();
			T.Mostrar();
			
			Tecnico_en_piso TP = new Tecnico_en_piso();
			TP.Mostrar();
			
			Tecnico_comercial TC = new Tecnico_comercial();
			TC.VerTurno();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}