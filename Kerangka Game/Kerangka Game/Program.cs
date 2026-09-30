// Game
// Genre : PvP
// Karakter : Nama, Kesehatan, 

using System;
namespace KarakterGame
{
    class Karakter
    {
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }
        public int jumlahSenjata { get; private set; }

        //Membuat konstruktor untuk menginisialisasi atribut
        public Karakter(string nama, int kesehatan, int senjata, int jumlahSenjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
            this.jumlahSenjata = jumlahSenjata;
        }

        public void Serang(Karakter target) //membuat method menyerang
        {
            Console.WriteLine("===> Mulai Serangan");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} Diserang dengan {jumlahSerangan}. Sisa Kesehatan: {kesehatan}");
        }

        public void Healing()
        {
            kesehatan += 20;
            Console.WriteLine($"{nama} melakukan healing. Kesehatan sekarang: {kesehatan}");
        }

        public void getData()

        {
            Console.WriteLine($"Karakter: {nama}, Kesehatan: {kesehatan}, Senjata: {senjata}, Jumlah Senjata: {jumlahSenjata}");
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {


            Karakter player1 = new Karakter("Dhinezad", 100, 25, 2); //membuat objek
            Karakter musuh = new Karakter("Zobie", 100, 20, 1);
            //interaksi antar objek
            player1.Serang(musuh); //memanggil method menyerang
            player1.getData();
            musuh.Serang(player1);
            player1.Healing();
            player1.getData();

        }
    }
}
