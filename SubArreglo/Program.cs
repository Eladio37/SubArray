using System;
using System.Collections.Generic;

namespace SubArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            do
            {
                Console.Write("Inserte la cantidad de elementos: ");
                cantidad = int.Parse(Console.ReadLine());
            } while (cantidad <= 0);
            int[] arreglo = null;
            arreglo = Create(cantidad);
            Calculate(arreglo);
        }
        public static int[] Create(int cantidad)
        {
            int[] arreglo = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Elemento [{i + 1}]: ");
                var value = int.Parse(Console.ReadLine());
                arreglo[i] = value;
            }
            return arreglo;
        }
        public static void Print(int[] arreglo)
        {
            Console.Write("[ ");
            foreach (var item in arreglo)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("]");
        }
        public static void Calculate(int[] arreglo)
        {
            int aux2, aux3, k, suma = 0;
            aux2 = aux3 = 0;
            int mayor = arreglo[0];
            List<int> temp = new List<int>();
            List<int> final = new List<int>();

            for (int i = 0; i < arreglo.Length; i++)
            {
                aux2 = 0;
                for (int j = i; aux2 < arreglo.Length - 1; j++)
                {
                    if (j == arreglo.Length && i != 0)
                    {
                        j = 0;
                    }
                    for (k = i; aux3 <= aux2; k++)
                    {
                        if (k == arreglo.Length)
                        {
                            k = 0;
                        }
                        //Console.Write($"{arreglo[k]}->");
                        suma += arreglo[k];
                        temp.Add(arreglo[k]);
                        aux3++;
                    }
                    //Console.WriteLine($" Suma = {suma}");
                    if (suma > mayor)
                    {
                        mayor = suma;
                        final.Clear();
                        foreach (var item in temp)
                        {
                            final.Add(item);
                        }
                    }
                    temp.Clear();
                    suma = 0;
                    aux3 = 0;
                    aux2++;
                }
            }
            Print(ListToArray(final));
            Console.WriteLine($"; Cuya sumatoria es: {mayor}");
        }
        public static int[] ListToArray(List<int> lista)
        {
            int[] arreglo = new int[lista.Count];
            int i = 0;
            foreach (var item in lista)
            {
                arreglo[i] = item;
                i++;
            }
            return arreglo;
        }
    }
}
