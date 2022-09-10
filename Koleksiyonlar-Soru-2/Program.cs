using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int[] allNumbers = new int[20];
            int[] biggest = new int[3];
            int[] lowest = new int[3];

            

            for (int i = 0; i < 20; i++)
            {           
                Console.WriteLine(i+1 + ". elemanı giriniz: ");
                allNumbers[i] = int.Parse(Console.ReadLine());
            }   

            Array.Sort(allNumbers);
            lowest[0] = allNumbers[0];
            lowest[1] = allNumbers[1];
            lowest[2] = allNumbers[2];

            int lowestSum = 0;

            Console.WriteLine("En küçük 3 sayının listesi");
            foreach (int item in lowest)
            {
                Console.WriteLine(item);
                lowestSum+=item;
            }

            int lowestAverage = lowestSum/lowest.Length; 

            Console.WriteLine("En küçük 3 sayının ortalaması: " + lowestSum/lowest.Length);

            biggest[0] = allNumbers[17];
            biggest[1] = allNumbers[18];
            biggest[2] = allNumbers[19];

            int biggestSum = 0;

            Console.WriteLine("En büyük 3 sayının listesi");
            foreach (int item in biggest)
            {
                Console.WriteLine(item);
                biggestSum+=item;   
            }
            
            int biggestAverage = biggestSum/biggest.Length;

            Console.WriteLine("En büyük 3 sayının ortalaması: " + biggestAverage);

            Console.WriteLine("En büyük ve en küçük 3 sayının ortalamalarının toplamı : " + (lowestAverage + biggestAverage));
        }
    }
}
