/*
 * Creado por SharpDevelop.
 * Usuario: MIKE
 * Fecha: 15/6/2024
 * Hora: 21:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proy_Institucion
{
	class Program
	{
		public static void Main(string[] args)
		{	
			Persona P = new Persona();
			Materia Ma = new Materia();
			Estudiante E = new Estudiante(Ma);
			
			
			Catedratico CAT = new Catedratico();
			Semestre S = new Semestre(CAT,E);
			
			Carrera C = new Carrera(S);
			
			C.Mostrar();
			
			//b)primera forma
			//C.buscarNacionalidad();
			//2da forma
			//C.buscarNacionalidad3();
			
			//C)1ra forma
			//C.mostrarNota();
			//2da forma
			//C.mostrarNota5();
			
			//d)1ra forma
			//C.CorregirNota();
			//2da forma
			//C.CorregirNota5();
			
			//E)1ra forma
			C.modificarSueldo();
			//2da forma
			
			
			//f)1ra forma
			//C.buscarEstudiantes();
			//2da forma
			//C.buscarEstudiantes5();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}