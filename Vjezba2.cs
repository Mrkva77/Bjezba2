using System;
 
namespace Vjezba2
{

    public class KlasaC
    {

        public int Zbroj(int[] Brojeva)
        {
            int suma = 0;
            foreach (int broj in Brojeva)
            {
                suma += broj;
            }
            return suma;
        }

        public double Prosjek(int[] Brojeva)
        {
            int suma = Zbroj(Brojeva);
            double prosjek = (double)suma / Brojeva.Length;
            return prosjek;
        }
    }
 
    public class Program
    {
        public static void Main()
        {
      
            var objekt = new KlasaC();
 
         
            int[] array = new int[5];
            Console.WriteLine("Unesi 5 cjelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Broj {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
 
            
            int suma = objekt.Zbroj(array);
            double aprosjek = objekt.Prosjek(array);
 
            
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Prosjek: {prosjek}");
        }
    }
}