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
	/// Description of Carrera.
	/// </summary>
	public class Carrera
	{
		private string nombre;
		private short cant_Semestres;
		private Semestre[] Se;
		
		
		public Carrera(Semestre se)
		{
			nombre = "Sistemas";
			
			cant_Semestres = 1;
			Se = new Semestre[cant_Semestres];
			for(int i=0;i<cant_Semestres;i++)
				Se[i]= se;
		}
		public void Llenar(){
			Console.Write("\n               --------DATOS DE CARRERA--------");
			Console.Write("\nIngrese nombre de la carrera: ");
			nombre = Console.ReadLine();
			Console.Write("\nIngrese cantidad de semestres: ");
			cant_Semestres = short.Parse(Console.ReadLine());
			for(int i=0;i<cant_Semestres;i++)
				Se[i].Llenar();
		}
		public void Mostrar(){
			Console.Write("\n               --------MOSTRANDO DATOS DE CARRERA--------");
			Console.Write("\nNombre Carrera: "+nombre);
			Console.WriteLine("\nCantidad Semestres: "+cant_Semestres);
			for(int i=0;i<cant_Semestres;i++)
				Se[i].Mostrar();
		}
		//B) 1ra forma
		public void buscarNacionalidad(){
			Console.Write("\nIngrese nacionalidad a buscar:");
			string x =Console.ReadLine().ToLower();
			int contN = 0;
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getCATEDRATICO()[i].getNacionalidad().ToLower().Equals(x))
					Console.Write("\nNombre: "+Se[i].getCATEDRATICO()[i].getNombres());
					Console.Write("\nTelefono: "+Se[i].getCATEDRATICO()[i].getTelefono());
					contN++;
			}
			Console.WriteLine("\ncantidad de personas -Catedratico-: "+contN);
			
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getESTUDIANTE()[i].getNacionalidad().ToLower().Equals(x))
					Console.Write("\nNombre: "+Se[i].getESTUDIANTE()[i].getNombres());
					Console.Write("\nTelefono: "+Se[i].getESTUDIANTE()[i].getTelefono());
					contN++;
			}
			Console.WriteLine("\ncantidad de personas -Estudiante-: "+contN);
		}
		//B)2da forma
		public void buscarNacionalidad3(){
			Console.Write("\nIngrese nacionalidad a buscar:");
			string x =Console.ReadLine();
			int cont_N =0;
			for(int i=0;i<cant_Semestres;i++){
				cont_N=Se[i].buscarNacionalidad2(x,cont_N);
			}
			Console.WriteLine("\nCantidad de personas = "+cont_N);
		}
		//c)1ra forma
		public void mostrarNota(){
			Console.Write("\nIngrese ci del estudiante a buscar: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese la materia: ");
			string y = Console.ReadLine().ToLower();
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getESTUDIANTE()[i].getCi().Equals(x)){
					if(Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNombre().ToLower().Equals(y)){
						Console.WriteLine("\nNOTA FINAL = "+Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNota().getNotaFinal());
					}
				}
			}
		}
		//c)2da forma
		public void mostrarNota5(){
			for(int i=0;i<cant_Semestres;i++)
				Se[i].mostrarNota4();
		}
		//D)1ra forma
		public void CorregirNota(){
			Console.Write("\nIngrese Ci de estudiante a buscar: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese nota nueva: ");
			short y = short.Parse(Console.ReadLine());
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getESTUDIANTE()[i].getCi().Equals(x)){
					Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNota().setNota_2(y);
					Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNota().Mostrar();
				}
			}
		}
		//d)2da forma
		public void CorregirNota5(){
			for(int i=0;i<cant_Semestres;i++)
				Se[i].CorregirNota4();
		}
		//e)1ra forma
		public void modificarSueldo(){
			Console.Write("\nIngrese item de catedratico: ");
			int x = int.Parse(Console.ReadLine());
			Console.Write("\nIngrese nacionalidad de catedratico: ");
			string y = Console.ReadLine().ToLower();
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getCATEDRATICO()[i].getItem().Equals(x)){
					if(Se[i].getCATEDRATICO()[i].getNacionalidad().ToLower().Equals(y)){
						Se[i].getCATEDRATICO()[i].setSueldo(Se[i].getCATEDRATICO()[i].getSueldo()+Se[i].getCATEDRATICO()[i].getSueldo()*0.2);
						Se[i].getCATEDRATICO()[i].Mostrar();
					}
				}
			}
		}
		//f)1ra forma
		public void buscarEstudiantes(){
			Console.Write("\nIngrese periodo: ");
			string x =Console.ReadLine();
			Console.Write("\nIngrese materia: ");
			string y = Console.ReadLine().ToLower();
			for(int i=0;i<cant_Semestres;i++){
				if(Se[i].getPeriodo().Equals(x)){
					if(Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNombre().ToLower().Equals(y)){
						Console.Write("\nNombre del estudiante = "+Se[i].getESTUDIANTE()[i].getNombres());
						Console.Write("\nMatricula del estudiante = "+Se[i].getESTUDIANTE()[i].getMatricula());
						Console.WriteLine("\nObservacion = "+Se[i].getESTUDIANTE()[i].getMATERIA()[i].getNota().getObservacion());
					}
				}
			}			
		}
		//f)2da forma
		public void buscarEstudiantes5(){
			for(int i=0;i<cant_Semestres;i++)
				Se[i].buscarEstudiantes4();
		}
	}
}
