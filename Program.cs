using System;

namespace primer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
        int a = 3;
		int b = 6;
		int c = 9;
		
        Console.WriteLine("ENUNCIADO");
        Console.WriteLine("Hacer un programa que produzca números aacb, bca, bcbc");
		Console.WriteLine("donde muestre un número de tres dígitos formado por tres");
        Console.WriteLine("variables numéricas en diferentes combinaciones.");
       
        Console.WriteLine();
        Console.WriteLine("Los números establecidos por el operador son: a = 3, b = 6, c = 9.");

        //PRIMER ORDEN: AACB
		Console.WriteLine("PRIMER ORDEN:");
        Console.Write(a);
		Console.Write(a);
		Console.Write(c);
		Console.WriteLine(b);
		
		Console.WriteLine();
		
		//SEGUNDO ORDEN: BCA
		Console.WriteLine("SEGUNDO ORDEN:");
        Console.Write(b);
		Console.Write(c);
		Console.WriteLine(a);
		
		Console.WriteLine();

		//TERCER ORDEN: BCBC
		Console.WriteLine("TERCER ORDEN:");
        Console.Write(b);
		Console.Write(c);
		Console.Write(b);
		Console.WriteLine(c);
        
					
		
		
	
        }
    }
}
