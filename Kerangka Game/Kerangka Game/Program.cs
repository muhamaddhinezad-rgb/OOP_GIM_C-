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
                Console.WriteLine("===> Mulai Serangan <===");
                target.TerimaSerangan(this.senjata);
            }

            public void TerimaSerangan(int jumlahSerangan) // method objek menerima serangan
            {
                kesehatan -= jumlahSerangan;
                Console.WriteLine($"{nama} Diserang dengan {jumlahSerangan}. Sisa Kesehatan: {kesehatan}");
            }

            public void Healing() //method untuk melakukan healing  
            {
                kesehatan += 20;
                Console.WriteLine($"{nama} melakukan healing. Kesehatan sekarang: {kesehatan}");
            }

            public void Posisi() //method untuk perpindahan posisi karakter
            {
            int posisiSekarang = 0;

            Console.WriteLine("===> Perpindahan Posisi Karakter <===");
            Console.WriteLine($"Karaktermu : {nama} / Kekuatan : {senjata} / Kesehatan : {kesehatan}");
            Console.WriteLine($"Posisi saat ini : {posisiSekarang}");

            while (true) // Mengulang program terus-menerus sampai dihentikan
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true); // Membaca tombol keyboard tanpa menampilkannya di terminal
            
                if (tombol.Key == ConsoleKey.RightArrow) // Mengecek apakah tombol panah kanan ditekan
                {
                    posisiSekarang += 2; // Menambah posisi sebanyak 2 angka
                }
                else if (tombol.Key == ConsoleKey.LeftArrow) // Mengecek apakah tombol panah kiri ditekan
                {
                    posisiSekarang -= 1; // Mengurangi posisi sebanyak 1 angka
                }
                else if (tombol.Key == ConsoleKey.Escape) // Mengecek apakah tombol Esc ditekan
                {
                    Console.WriteLine("permainan Berhenti"); // Menampilkan tulisan permainan Berhenti
                    break; // Menghentikan perulangan while
                }
                else
                {
                    continue; // Melewati tombol lain dan kembali membaca input keyboard
                }
            
                Console.WriteLine($"Posisi saat ini : {posisiSekarang}"); // Menampilkan posisi karakter terbaru
            }
        }

            public void getData()

            {
                Console.WriteLine($"Karakter: {nama}, Kesehatan: {kesehatan}, Damage Senjata: {senjata}, Jumlah Senjata: {jumlahSenjata}");
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
                player1.Posisi();
            }
        }
    }
