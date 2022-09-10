using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();
            Regex rgx = new Regex("^[0-9]*$");

            int sayac = 1;
            while(sayac<21)
            {
                Console.WriteLine(sayac + ". sayıyı giriniz");
                string number = Console.ReadLine();
                if(!rgx.IsMatch(number) || (Convert.ToInt32(number)) < 0)
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz: Sayı pozitif olmalı ve harf içermemelidir.");
                else
                {
                    int sayi1 = Convert.ToInt32(number);
                    int sonuc = IsPrime(sayi1);
                    if (sonuc == 0)
                    {
                        nonPrimeNumbers.Add(sayi1);
                        sayac ++;
                    }
                    else 
                    {
                        primeNumbers.Add(sayi1);
                        sayac ++;
                    }
                }    
            }

            int primeSum = 0;
            int nonPrimeSum = 0;

            primeNumbers.Sort();
            nonPrimeNumbers.Sort();

            Console.WriteLine("Asal sayılar");
            foreach (int i in primeNumbers)
            {
                Console.WriteLine(i); 
                primeSum+= i;  
            }  

            Console.WriteLine("Asal olmayan sayılar");
            foreach (int a in nonPrimeNumbers)
            {
                Console.WriteLine(a);
                nonPrimeSum+=a;
            }

            Console.WriteLine("Klavyeden girilen asal sayıların ortalaması:" + (primeSum/primeNumbers.Count));
            Console.WriteLine("Girilen asal olmayan sayıların ortalaması: " + nonPrimeSum/nonPrimeNumbers.Count);

            Console.ReadKey();
        }
        private static int IsPrime(int number)
        {
            int i;
            for (i = 2; i <= number -1 ; i++)
            {
                if(number % i == 0)
                {
                    return 0;
                }
            }
            if(i == number)
            {
                return 1;
            }
            return 0;

        }
    }
}
