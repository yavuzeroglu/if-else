using System;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("1. notunuzu giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. notunuzu giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());

            if(not1>=1 && not1<100 && not2>=1 && not2<100) {
                double ort = (not1+not2)/2;
                Console.WriteLine("Iki notunuzun Ortalamasi :" +ort);
            }
            else
            Console.WriteLine("Notlar 0-100 arası olmak zorundadır tekrar not girişi yapınız");
            
            
            
             

        }
    }
}