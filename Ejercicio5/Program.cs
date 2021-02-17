using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //llamamos al methodo que nos crea la lista
            var listaString =  CreateListString("Uno", "Dos", "tres");          
            // print data
            Console.WriteLine();
            Console.WriteLine("Impresión de una lista"); 
            listaString.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine("");

        // creamos una tupla.
        (double num1, int num2, int num3, string name) tupla = (4.21, 2, 4, "Nombre");
        Console.WriteLine();
        Console.WriteLine("Impresión de una tupla"); 
        Console.WriteLine(tupla);


        // creamos una dicionario.
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("exe", "Aplicacion");
        dic.Add("doc", "Documento1");
        dic.Add("jpg", "Imagen");
        dic.Add("gif", "Imagen");
        dic.Add("txt", "texto");
        dic.Add("rfc", "Documento2");
       



        Console.WriteLine();
        Console.WriteLine("Impresión de diccionario");
        foreach( KeyValuePair<string, string> kvp in dic )
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }

    }

        private static List<string> CreateListString(params string[] lista){
            //instacicion de la classe lista
            List<string> listaString = new List<string>();

            foreach (var ls in lista)
            {
                listaString.Add(ls);
            }
            return listaString;
        }
    }
}
