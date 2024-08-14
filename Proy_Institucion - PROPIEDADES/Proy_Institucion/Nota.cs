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
	/// Description of Nota.
	/// </summary>
	public class Nota
	{
		private short Nota_1;
		private short Nota_2;
		private short Nota_3;
		private short Nota_ayudantia;
		private short Nota_final;
		private string Observacion;
		public Nota()
		{
			Nota_1 = 96;
			Nota_2 = 74;
			Nota_3 = 61;
			Nota_ayudantia = 7;
			Nota_final = 72;
			Observacion = "Aprobo";
		}
		public void Llenar(){
			Console.Write("\n--------DATOS DE NOTA--------");
			Console.Write("\nIngrese nota 1: ");
			Nota_1 = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese nota 2: ");
			Nota_2 = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese nota 3: ");
			Nota_3 = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese nota de ayuda: ");
			Nota_ayudantia = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese nota final: ");
			Nota_final = short.Parse(Console.ReadLine());
			Console.Write("\nIngrese la observacion: ");
			Observacion = Console.ReadLine();
		}
		public void Mostrar(){
			Console.Write("\n--------MOSTRANDO DATOS DE LA NOTA--------");
			Console.Write("\nNota 1: "+Nota_1);
			Console.Write("\nNota 2: "+Nota_2);
			Console.Write("\nNota 3: "+Nota_3);
			Console.Write("\nNota Ayudantia: "+Nota_ayudantia);
			Console.Write("\nNota Final: "+Nota_final);
			Console.WriteLine("\nObservacion: "+Observacion);
		}
		public short nota1{
			get{return Nota_1;}
			set{Nota_1=value;}
		}
		public short nota2{
			get{return Nota_2;}
			set{Nota_2=value;}
		}
		public short nota3{
			get{return Nota_3;}
			set{Nota_3=value;}
		}
		public short NotaAyun{
			get{return Nota_ayudantia;}
			set{Nota_ayudantia=value;}
		}
		public short NotaFinal{
			get{return Nota_final;}
			set{Nota_final=value;}
		}
		public string observacion{
			get{return observacion;}
			set{observacion=value;}
		}
	}
}
