using System;

namespace Arreglos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("ingrese 10 valores #" + (i + 1).ToString());
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            MostrarElementos(arreglo);
            Console.WriteLine("La suma de los elementos es: " + SumaElementos(arreglo).ToString());
            Console.WriteLine("El promedio de los elementos es: " + promedio(arreglo).ToString());
            Console.WriteLine("El numero menor de los elementos es: " + MenorElemento(arreglo).ToString());
            Console.WriteLine("El numero mayor de los elementos es: " + MayorElemento(arreglo).ToString());
            Console.ReadKey();
        }
   

        static void MostrarElementos(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        
        static int SumaElementos(int[] arreglo)
        {
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
                

                }
                return suma;

        }
        static double promedio(int[] arreglo)
        {
            int SumaElemento = SumaElementos(arreglo);
                
                return SumaElemento / arreglo.Length;


        }
        static int MenorElemento(int[] arreglo)
        {
            int menor = arreglo[0];
           
                for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] < menor)
                    menor = arreglo[i];
            }
            return menor;
        }
        static int MayorElemento(int[] arreglo)
        {
            int mayor = arreglo[0];
            
                for (int i = 1; i < arreglo.Length; i++)
            {
                if (arreglo[i] > mayor)
                    mayor = arreglo[i];
            }
            return mayor;
        }
    

        }
    }
}
