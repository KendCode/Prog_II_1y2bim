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
		
		//Get-Set nota 2
		public string getNombres(){
			return nombres;
		}
		public void setNombres(string nombres){
			this.nombres = nombres;
		}
		
		//Get-Set nota 3
		public string getApellidos(){
			return apellidos;
		}
		public void setApellidos(string apellidos){
			this.apellidos = apellidos;
		}
		
		//Get-Set nota 2
		public int getCi(){
			return ci;
		}
		public void setCi(int ci){
			this.ci = ci;
		}
		
		//Get-Set nota 3
		public string getDireccion(){
			return direccion;
		}
		public void setDireccion(string direccion){
			this.direccion = direccion;
		}
		
		//Get-Set nota 2
		public int getTelefono(){
			return telefono;
		}
		public void setTelefono(int telefono){
			this.telefono = telefono;
		}
		
		//Get-Set nota 3
		public string getNacionalidad(){
			return nacionalidad;
		}
		public void setNacionalidad(string nacionalidad){
			this.nacionalidad = nacionalidad;
		}
		
		//Get-Set nota 2
		public string getFechaNacimiento(){
			return fecha_nacimiento;
		}
		public void setFechaNacimiento(string fecha_nacimiento){
			this.fecha_nacimiento = fecha_nacimiento;
		}
		//b)2da forma
		public void buscarNacionalidad1(string x){
			if(nacionalidad.ToLower().Equals(x)){
				Console.Write("\nnombre = "+nombres);
				Console.Write("\ntelefono = "+telefono);
			}
		}
	}
}
