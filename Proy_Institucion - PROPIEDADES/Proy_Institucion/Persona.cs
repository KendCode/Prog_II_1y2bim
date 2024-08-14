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
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nombres;
		protected string apellidos;
		protected int ci;
		protected string direccion;
		protected int telefono;
		protected string nacionalidad;
		protected string fecha_nacimiento;
		
		public Persona()
		{
			nombres = "RAMON";
			apellidos = "CALLE";
			ci = 11111;
			direccion = "Av.SAN PEDRO";
			telefono = 2583699;
			nacionalidad = "PERU";
			fecha_nacimiento = "25 de junio";

		}
		public void Llenar(){
			Console.Write("\n--------DATOS DE PERSONA--------");
			Console.Write("\nIngrese nombre: ");
			nombres = Console.ReadLine();
			Console.Write("\nIngrese Apellido: ");
			apellidos = Console.ReadLine();
			Console.Write("\nIngrese CI: ");
			ci = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese Direccion: ");
			direccion = Console.ReadLine();
			Console.Write("\nIngrese Telefono: ");
			telefono = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese Nacionalidad: ");
			nacionalidad = Console.ReadLine();
			Console.Write("\nIngrese Fecha de Nacimiento: ");
			fecha_nacimiento = Console.ReadLine();
		}
		public void Mostrar(){
			Console.Write("\n--------MOSTRANDO DATOS DE PERSONA--------");
			Console.Write("\nNombres: "+nombres);
			Console.Write("\nApellidos: "+apellidos);
			Console.Write("\nCI: "+ci);
			Console.Write("\nDireccion: "+direccion);
			Console.Write("\nTelefono: "+telefono);
			Console.Write("\nNacionalidad: "+nacionalidad);
			Console.WriteLine("\nFecha de Nacimiento: "+fecha_nacimiento);
		}
		public string Nombre{
			get{return nombres;}
			set{nombres=value;}
		}
		public string Apellido{
			get{return apellidos;}
			set{apellidos=value;}
		}
		public int Ci{
			get{return ci;}
			set{ci=value;}
		}
		public string Direccion{
			get{return direccion;}
			set{direccion=value;}
		}
		public int Telefono{
			get{return telefono;}
			set{telefono=value;}
		}
		public string Nacionalidad{
			get{return nacionalidad;}
			set{nacionalidad=value;}
		}
		public string FechaNac{
			get{return fecha_nacimiento;}
			set{fecha_nacimiento=value;}
		}
	}
}
