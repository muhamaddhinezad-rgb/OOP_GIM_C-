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

        public void Posisi()
        {
            Console.WriteLine("\n===> Perpindahan Posisi Karakter <===");
            Console.WriteLine("Mana yang kamu pilih?");
            Console.WriteLine("1. Perpindahan angka");
            Console.WriteLine("2. Tombol di keyboard");
            Console.Write("Pilihan mu (1 atau 2) : ");

            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                PosisiAngka();
            }
            else if (pilihan == "2")
            {
                PosisiKeyboard();
            }
            else
            {
                Console.WriteLine("Pilihan tidak tersedia!");
            }
        }

        // Method untuk memasukkan posisi menggunakan angka
        public void PosisiAngka()
        {
            int posisiAwal = 0;

            Console.WriteLine("\n===> Perpindahan Angka <===");
            Console.WriteLine($"Karaktermu: {nama}");
            Console.WriteLine($"Posisi saat ini : {posisiAwal}");

            Console.Write("Masukkan jumlah posisi perpindahan : ");

            if (int.TryParse(Console.ReadLine(), out int posisiSekarang))
            {
                Console.WriteLine(
                    $"{nama} berpindah dari posisi {posisiAwal} ke posisi {posisiSekarang}"
                );
            }
            else
            {
                Console.WriteLine("Input harus berupa angka!");
            }
        }

        // Method untuk berpindah menggunakan tombol keyboard
        public void PosisiKeyboard()
        {
            int posisiSekarang = 0;

            Console.WriteLine("\n===> Perpindahan Posisi Karakter <===");
            Console.WriteLine(
                $"Karaktermu: {nama} / Kekuatan: {senjata} / Kesehatan: {kesehatan}"
            );
            Console.WriteLine($"Posisi saat ini: {posisiSekarang}");
            Console.WriteLine("Arrow Right: Posisi +2");
            Console.WriteLine("Arrow Left : Posisi -1");
            Console.WriteLine("Esc        : Berhenti");

            while (true)
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true);

                if (tombol.Key == ConsoleKey.RightArrow)
                {
                    posisiSekarang += 2;
                }
                else if (tombol.Key == ConsoleKey.LeftArrow)
                {
                    posisiSekarang -= 1;
                }
                else if (tombol.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("permainan Berhenti");
                    break;
                }
                else
                {
                    continue;
                }

                Console.WriteLine($"Posisi saat ini: {posisiSekarang}");
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
                // Membuat objek karakter
                Karakter player1 = new Karakter("Dhinezad", 100, 25, 2);
                Karakter musuh = new Karakter("Zobie", 100, 20, 1);

                // Interaksi antar karakter
                player1.Serang(musuh);
                player1.getData();

                musuh.Serang(player1);

                player1.Healing();
                player1.getData();

                // Menjalankan menu perpindahan posisi
                player1.Posisi();
            }
        }
    }
