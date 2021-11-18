using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen seçiminizi yapınız! Artan için Y azalan için N tuşuna basınız");
            String secim = Console.ReadLine();
            Console.WriteLine("Lütfen başlangıç değerini giriniz");
            int basdeger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen son değerini giriniz");
            int sondeger = Convert.ToInt32(Console.ReadLine());

            if (sondeger != null)
            {
                if (secim == "Y" || secim == "y")
                {
                    for (int i = basdeger; i <= sondeger; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (secim == "N" || secim == "n")
                {
                    for (int i = basdeger; i >= sondeger; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
           
            
        }
    }
}
