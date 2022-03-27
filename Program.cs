using System;
using System.Collections.Generic;

namespace EjemploLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agregar elementos Lista
            IList<int> entero = new List<int>();

            entero.Add(2);
            entero.Add(3);

            IList<string> cadena = new List<string>();

            cadena.Add("dos");
            cadena.Add("Tres");

            IList<int> entero1 = new List<int>() { 2, 3 };
            IList<string> cadena1 = new List<string>() { "dos", "tres" };


            //método AddRange
            //Agregar el contenido que tengamos en una collección
            //En la nueva lista que tengamos

            List<int> entero3 = new List<int>();
            entero3.AddRange(entero);

            Console.WriteLine("El valor en la posición 1 de mi lista es; {0}", entero[0]);

            foreach (int i in entero)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <  entero.Count; i ++)
            {
                Console.WriteLine(entero[i]);
            }

            //Insertar elementos a la colección genérica List

             IList<int> entero4 = new List<int>() { 2, 3 };

            //Nosotros decidimo donde insertar el elemento
            entero4.Insert(2,5);

            foreach (var i in entero4)
            {
                Console.WriteLine( "ultimo:"+i);
            }

            //Eliminar elementos de la colección genérica list

            IList<int> entero5 = new List<int>() { 1, 2, 3, 4 };

            entero5.Remove(2);//Elimina el primer valor número 2 que se encuentre en la lista

            entero5.RemoveAt(2);//Eliminar el elemnto que está en la segunda posición de la lsita

            foreach (var i in entero5)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}

