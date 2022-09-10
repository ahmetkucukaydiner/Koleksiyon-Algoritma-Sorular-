using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            ArrayList sesliHarfler = new ArrayList(); 

            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string sesli = "aeıioöuü";
            

            for (int i = 0; i < cumle.Length; i++)
            {
                
                if(sesli.Contains(cumle.ToLower()[i]))
                    sesliHarfler.Add(cumle.ToLower()[i]);
                
            }
            
            sesliHarfler.Sort();

            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
