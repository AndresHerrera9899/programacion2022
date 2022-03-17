using System;

namespace Contar
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            int contar=10;
            int producto=1;

            //while (contar <=20){
                
            //    producto = producto * contar;
            //    contar = contar + 2;               

            //}        

            for (int i=10; i <=20; i= i +2){

                producto = producto * i;

                contar = i;
            }

            Console.WriteLine(contar);
            Console.WriteLine(producto);

            suma = contar + producto;
            
            Console.WriteLine(suma);

        }
    }
}