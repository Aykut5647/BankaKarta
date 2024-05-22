using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaKarta
{
 
    internal class Adres
    {
        public static string Mestopolojenie
        { get; set; }
        public static string Ulica
        { get; set; }
 

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko danni shte vuvejdash?");
            int n = int.Parse(Console.ReadLine());
            string[] mestopolojenie = new string[n];
            string[] ulica = new string[n];
            string[] ime = new string[n];
            string[] familiq=new string[n];
            int[] nomerkarta= new int[n];
            double[] vkaranipari = new double[n];
            double[] lihva=new double[n];
            double[] iztegleni=new double[n];

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Kide jivee:");
                Adres.Mestopolojenie = Console.ReadLine();
                mestopolojenie[i] = Adres.Mestopolojenie;

                Console.WriteLine("Koq ulica:");
                Adres.Ulica = Console.ReadLine();
                ulica[i] = Adres.Ulica;

                Console.WriteLine("Kak se kazva:");
                Karta.Ime = Console.ReadLine();
                ime[i] = Karta.Ime;

                Console.WriteLine("Familiq:");
                Karta.Familiq = Console.ReadLine();
                familiq[i] = Karta.Familiq;

                Console.WriteLine("Nomer:");
                Karta.NomerKarta = int.Parse(Console.ReadLine());
                nomerkarta[i] = Karta.NomerKarta;

                Console.WriteLine("Vkarani pari:");
                Nalicnost.VkaraniPari= double.Parse(Console.ReadLine());
                vkaranipari[i] = Nalicnost.VkaraniPari;

                Console.WriteLine("Lihva:");
                Nalicnost.Lihva = double.Parse(Console.ReadLine());
                lihva[i] = Nalicnost.Lihva;

                Console.WriteLine("Iztegleni:");
                Nalicnost.Iztegleni = double.Parse(Console.ReadLine());
                iztegleni[i] = Nalicnost.Iztegleni;
            }
            for (int i=0;i<n;i++)
            {
                Console.WriteLine($"Mestopolojenie: {mestopolojenie[i]}, Ulica: {ulica[i]}, Ime: {ime[i]}, Familiq: {familiq[i]}, Nomer: {nomerkarta[i]}, Vkarani pari: {vkaranipari[i]}, Procent na lihvata: {lihva[i]}, Iztegleni pari: {iztegleni[i]}.");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Izhod lihva");
                Console.WriteLine("Za kraq na meseca imash:" + vkaranipari[i] / lihva[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dali shte teglish?");
                if (vkaranipari[i]<=10)
                {
                    Console.WriteLine(ime[i] + " " + vkaranipari[i]);
                }
                else
                {
                    Console.WriteLine("Nqma takiva");
                }
            }
            for (int i = 0; i < n; i++)
            {
                Karta.Izhod();


            }
        }
    }
}
