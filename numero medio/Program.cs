using System;

namespace numero_medio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Dijite el numero");
            a = int.Parse(Console.In.ReadLine());


            Console.WriteLine("Dijite el numero");
            b = int.Parse(Console.In.ReadLine());


            Console.WriteLine("Dijite el numero");
            c = int.Parse(Console.In.ReadLine());

            if (a <= b && b <= c){
                Console.WriteLine("El numero medio es: " + b + "");
            }if(a <= c && c <= b)
            {
                Console.WriteLine("El numero medio es: " + c + "");
            }if(b <= a && a <= c)
            {
                Console.WriteLine("El numero medio es: " + a + "");
            }if(b <= c && c <= a)
            {
                Console.WriteLine("El numero medio es: " + c + "");
            }if(c <= a && a <= b)
            {
                Console.WriteLine("El numero medio es: " + a + "");
            }if(c <= b && b <= a)
            {
                Console.WriteLine("El numero medio es: " + b + "");
            }


        }
    }
}
