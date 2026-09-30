// Game
// Genre : PvP
// Karakter : Nama, Kesehatan, 

using System;
namespace KarakterGame
{
    class Karakter
    {
        //public string kesehatan, senjata; //Atribut
        //public int jumlahSenjata, power;

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

        //public void setData(string namaBaru, string Kesehatanku, string Senjataku, int jumlahSenjata, int Power)
        //{
        //    this.nama = namaBaru;
        //    this.kesehatan = Kesehatanku;
        //    this.senjata = Senjataku;
        //    this.jumlahSenjata = jumlahSenjata;
        //    this.power = Power;
        //}

        public void getData()

        {
            Console.WriteLine($"Karakter: {nama}, Kesehatan: {kesehatan}, Senjata: {senjata}, Jumlah Senjata: {jumlahSenjata}");
        }

        //{
        //    Console.Write(nama);
        //    Console.Write(" / ");
        //    Console.Write(kesehatan);
        //    Console.Write(" / ");
        //    Console.Write(senjata);
        //    Console.Write(" / Jumlah Senjata: ");
        //    Console.Write(jumlahSenjata);
        //    Console.Write(" / Power: ");
        //    Console.WriteLine(power);
        //}


        //public void setKesehatan(string kesehatan)
        //{
        //    this.kesehatan = kesehatan;
        //}

        //public void getKesehatan()
        //{
        //    Console.WriteLine(kesehatan);
        //}
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


            //------"Kode Sebelumnya"-------
            //List<Karakter> daftarHero = new List<Karakter>(); //Array menyiapkan pahlawan

            //Karakter player1 = new Karakter();
            //player1.setData("Kipli", "Sehat", "Pistol", 2 , 25);
            ////player1.getData();

            //Karakter player2 = new Karakter();
            //player2.setData("Putri", "Sehat", "Tongkat", 1, 10);
            ////player2.getData();

            ////player.setKesehatan("Sehat");
            ////player.getKesehatan(); //metode membuat method baru

            ////Objek Musuh
            //Karakter enemy = new Karakter();
            //enemy.setData("Zobie", "sehat", "Tangan Kosong", 1, 15);
            //enemy.getData();

            //daftarHero.Add(player1);
            //daftarHero.Add(player2);

            ////menampilkan data diri array, foreach
            //foreach(Karakter player in daftarHero)
            //{
            //    player.getData();
            //}
        }
    }
}