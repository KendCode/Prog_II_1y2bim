/*
 * Created by SharpDevelop.
 * User: Kender
 * Date: 4/4/2024
 * Time: 11:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proy_Vehiculo
{
	/// <summary>
	/// Description of vehiculo.
	/// </summary>
	public class vehiculo
	{
		public string placa;
		public int modelo;
		public string chasis;
		public string color;
		public string marca;
		public vehiculo()
		{
			placa = "ABC1514";
			modelo = 12345;
			chasis = "XYZ132";
			color = "Rojo";
			marca = "ford";
		}
		// Constructor con parámetros para todos los campos
    	public vehiculo(string placa, int modelo, string chasis, string color, string marca)
    	{
        	this.placa = placa;
        	this.modelo = modelo;
        	this.chasis = chasis;
        	this.color = color;
        	this.marca = marca;
    	}
    	public vehiculo(string marca, string color, string chasis, int modelo, string placa){
    		this.marca = marca;
    		this.color = color;
    		this.chasis = chasis;
    		this.modelo = modelo;
    		this.placa = placa;
    	}
    	public vehiculo(int modelo, string placa, string marca, string color, string chasis){
    		this.modelo = modelo;
    		this.placa = placa;
    		this.marca = marca;
    		this.color = color;
    		this.chasis = chasis;
    	}
    	public vehiculo(string color,string marca){
    		this.color = color;
    		this.marca = marca;
    	}
		public static vehiculo operator ++(vehiculo v){
    		Console.WriteLine("--INGRESE LOS DATOS DE VEHICULO--");
			Console.Write("Ingrese la placa: ");
			v.placa = Console.ReadLine();
			Console.Write("Ingrese modelo: ");
			v.modelo = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el chasis: ");
			v.chasis = Console.ReadLine();
			Console.Write("Ingrese el color: ");
			v.color = Console.ReadLine();
			Console.Write("Ingrese de marca: ");
			v.marca = Console.ReadLine();
			
			return v;
		}
		
		public static vehiculo operator --(vehiculo v){
			Console.WriteLine("--DATOS DE VEHICULO--");
			Console.WriteLine("Placa: "+ v.placa);
			Console.WriteLine("Modelo: "+v.modelo);
			Console.WriteLine("Chasis: "+v.chasis);
			Console.WriteLine("Color: "+v.color);
			Console.WriteLine("Marca: "+v.marca);
			return v;
		}
    	//LEER DATOS
    	public void Leer(){
			Console.Write("Ingrese la placa: ");
			placa = Console.ReadLine();
			Console.Write("Ingrese modelo: ");
			modelo = int.Parse(Console.ReadLine());
			Console.Write("Ingrese el chasis: ");
			chasis = Console.ReadLine();
			Console.Write("Ingrese el color: ");
			color = Console.ReadLine();
			Console.Write("Ingrese de marca: ");
			marca = Console.ReadLine();
		}
    	 // Método para mostrar los datos del vehículo
    	public void Mostrar()
    	{
        	Console.WriteLine("Placa: " + placa);
        	Console.WriteLine("Modelo: " + modelo);
       	 	Console.WriteLine("Chasis: " + chasis);
        	Console.WriteLine("Color: " + color);
        	Console.WriteLine("Marca: " + marca);
    	}
    	//OPERRADORES BINARIO
    	public static vehiculo operator +(vehiculo V1, vehiculo V2)
    	{
        	vehiculo R = new vehiculo();

        // Concatenar los campos de los dos vehiculos
        	R.placa = V1.placa + " " + V2.placa;
        	R.modelo = V1.modelo + V2.modelo;
        	R.chasis = V1.chasis + " " + V2.chasis;
        	R.color = V1.color + " " + V2.color;
        	R.marca = V1.marca + " " + V2.marca;

        	return R;
   		}
	}
}
