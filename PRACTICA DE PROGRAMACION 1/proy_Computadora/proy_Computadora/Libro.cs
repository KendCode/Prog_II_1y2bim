/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 4/4/2024
 * Time: 15:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_Computadora
{
	/// <summary>
	/// Description of Libro.
	/// </summary>
	public class Libro
	{
		protected string titulo;
		protected string autor;
		protected int publicacion;
		protected string genero;
		protected int paginas;
		protected int precio;
		public Libro()
		{
			titulo = "La vaca";
			autor = "Carlos";
			publicacion = 2000;
			genero = "motivacion";
			paginas = 145;
			precio = 10;
		}
		public Libro(string titulo, string autor, int publicacion,
		             string genero, int paginas, int precio){
			this.titulo = titulo;
			this.autor = autor;
			this.publicacion = publicacion;
			this.genero = genero;
			this.paginas = paginas;
			this.precio = precio;
		}
		public void Leer(){
			Console.WriteLine("--INSERTAR LOS DATOS DE LIBRO");
			Console.Write("Ingrese el titulo: ");
			titulo = Console.ReadLine();
			Console.Write("Ingrese el autor: ");
			autor = Console.ReadLine();
			Console.Write("Ingrese la fecha de publicacion: ");
			publicacion = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el genero: ");
			genero = Console.ReadLine();
			Console.Write("Ingrese cuantas paginas: ");
			paginas = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el precio del libro: ");
			precio = int.Parse(Console.ReadLine());			
		}
		public void Mostrar(){
			Console.WriteLine("--DATOS DEL LIBRO--");
			Console.WriteLine("Titulo: "+titulo);
			Console.WriteLine("Autor: "+autor);
			Console.WriteLine("Publicacion: "+publicacion);
			Console.WriteLine("Genero: "+genero);
			Console.WriteLine("Total de paginas: "+paginas);
			Console.WriteLine("Precio: "+precio);
		}
	}
}
