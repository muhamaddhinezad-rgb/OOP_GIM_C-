using System;

public class Serangan
{
    static int playerHP = 50;
    public static void Main(string[] args)
    {
        System.Console.WriteLine("===> Serang Musuh! <===");
        Console.WriteLine("karakter : LaraCroft");
        List<string> LaraCroftWeapons = new List<string>() { "Arc", "Arrow" };
        foreach (string weapon in LaraCroftWeapons)
        {
            Console.WriteLine($"- {weapon}");
        }

        ambilSerangan(20);

        while (playerHP >= 1)
        {
            Console.Write("Masukan hit : ");
            int seranganUlang = Convert.ToInt32(Console.ReadLine());
            if (seranganUlang > playerHP)
            {
                Console.WriteLine("No no ya, itu melebihi limitnya.");
            }
            else
            {
                ambilSerangan(seranganUlang);
            }
        }

        Console.WriteLine("Musuh kalah!");
        Console.WriteLine("Congratulations! Your new achievment ...");

        LaraCroftWeapons.Add("Medkit");
        foreach (string weapon in LaraCroftWeapons)
        {
            Console.WriteLine($"- {weapon}");
        }

        Console.WriteLine($"Total Weapons : {LaraCroftWeapons.Count}");

    }

    //method serangan
    static void ambilSerangan(int efekSerangan)
    {
        playerHP -= efekSerangan;
        Console.WriteLine($"Terkena Serangan Sebesar {efekSerangan} . " + $"Sisa {playerHP}");

        if (playerHP <= 0)
        {
            Console.WriteLine("Innalilahi");
        }
        else if (playerHP <= 3)
        {
            Console.WriteLine("Sakaratul Maut");
        }
        else if (playerHP <= 10)
        {
            Console.WriteLine("Otw Kematian");
        }
        else if (playerHP <= 30)
        {
            Console.WriteLine("GWS bro!");
        }
        else
        {
            Console.WriteLine("serang Terus...");
        }
    }
}