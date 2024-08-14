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
		//Get-Set nota 1
		public short getNota_1(){
			return Nota_1;
		}
		public void setNota_1(short Nota_1){
			this.Nota_1 = Nota_1;
		}
		
		//Get-Set nota 2
		public short getNota_2(){
			return Nota_2;
		}
		public void setNota_2(short Nota_2){
			this.Nota_2 = Nota_2;
		}
		
		//Get-Set nota 3
		public short getNota_3(){
			return Nota_3;
		}
		public void setNota_3(short Nota_3){
			this.Nota_3 = Nota_3;
		}
		
		//Get-Set nota Ayudantia
		public short getNotaAyuda(){
			return Nota_ayudantia;
		}
		public void setNotaAyuda(short Nota_ayudantia){
			this.Nota_ayudantia = Nota_ayudantia;
		}
		
		//Get-Set nota 3
		public short getNotaFinal(){
			return Nota_final;
		}
		public void setNotaFinal(short Nota_final){
			this.Nota_final = Nota_final;
		}
		//Get-Set nota 3
		public string getObservacion(){
			return Observacion;
		}
		public void setObservacion(string Observacion){
			this.Observacion = Observacion;
		}
		//c)2da forma
		public void mostrarNota1(){
			Console.WriteLine("\nNOTA FINAL = "+Nota_final);
		}
		//d)2da forma
		public void CorregirNota1(){
			Console.Write("\nIngrese nota nueva: ");
			short y = short.Parse(Console.ReadLine());
			Nota_2 = y;
			Mostrar();
		}
		//f)2da forma
		public void buscarEstudiantes1(){
			Console.WriteLine("\nObservacion = "+Observacion);
		}
	}
}
