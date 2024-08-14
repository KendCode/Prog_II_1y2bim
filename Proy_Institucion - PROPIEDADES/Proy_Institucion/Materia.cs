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
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Sigla{
			get{return sigla;}
			set{sigla=value;}
		}
		public Nota NOTA{
			get{return No;}
			set{No=value;}
		}
	}
}
