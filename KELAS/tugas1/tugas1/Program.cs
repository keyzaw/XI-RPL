using System;

namespace tugas1
{
    public class Calculator
    {
        public int Tambah(int a, int b)
        {
            return a + b;
        }


    public int Kurang(int a, int b)
        {
            return a - b;
        }

        public int Kali(int a, int b)
        {
            return a * b;
        }

        public double Bagi(double a, double b)
        {
            return a / b;
        }
    }

    public class BangunDatar
    {
        public double LuasPersegi(double s)
        {
            return s * s;
        }

        public double LuasPersegiPanjang(double p, double l)
        {
            return p * l;
        }

        public double LuasSegitiga(double al, double t)
        {
            return 0.5 * al * t;
        }
    }

    public class BangunRuang
    {
        public double VolumeKubus(double sisi)
        {
            return sisi * sisi * sisi;
        }

        public double VolumeBalok(double p, double l, double t)
        {
            return p * l * t;
        }
    }

    public class Zodiak
    {
        public string TentukanZodiak(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19))
                return "Aries";

            else if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20))
                return "Taurus";

            else if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20))
                return "Gemini";

            else if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22))
                return "Cancer";

            else if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22))
                return "Leo";

            else if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22))
                return "Virgo";

            else if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22))
                return "Libra";

            else if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21))
                return "Scorpio";

            else if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21))
                return "Sagitarius";

            else if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19))
                return "Capricorn";

            else if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18))
                return "Aquarius";

            else if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20))
                return "Pisces";

            else
                return "Tanggal atau bulan tidak valid";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            BangunDatar bangundatar = new BangunDatar();
            BangunRuang bangunruang = new BangunRuang();
            Zodiak zodiak = new Zodiak();

            int pilihan;

            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine(" MENU UTAMA");
                Console.WriteLine("================================");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Bangun Datar");
                Console.WriteLine("3. Bangun Ruang");
                Console.WriteLine("4. Zodiak");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("================================");
                Console.Write("Pilih menu: ");

                pilihan = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("\n CALCULATOR");
                        Console.WriteLine("Hasil Tambah : " + calculator.Tambah(10, 5));
                        Console.WriteLine("Hasil Kurang : " + calculator.Kurang(10, 5));
                        Console.WriteLine("Hasil Kali   : " + calculator.Kali(10, 5));
                        Console.WriteLine("Hasil Bagi   : " + calculator.Bagi(10, 5));
                        break;

                    case 2:
                        Console.WriteLine("\n BANGUN DATAR");
                        Console.WriteLine("Luas Persegi          : " + bangundatar.LuasPersegi(5));
                        Console.WriteLine("Luas Persegi Panjang  : " + bangundatar.LuasPersegiPanjang(10, 5));
                        Console.WriteLine("Luas Segitiga         : " + bangundatar.LuasSegitiga(10, 5));
                        break;

                    case 3:
                        Console.WriteLine("\n BANGUN RUANG ");
                        Console.WriteLine("Volume Kubus : " + bangunruang.VolumeKubus(5));
                        Console.WriteLine("Volume Balok : " + bangunruang.VolumeBalok(10, 5, 4));
                        break;

                    case 4:
                        Console.WriteLine("\n ZODIAK ");
                        Console.Write("\nMasukkan tanggal lahir:\n ");
                        int tanggal = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nMasukkan bulan lahir:\n ");
                        int bulan = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nZodiak kamu adalah:\n "
                            + zodiak.TentukanZodiak(tanggal, bulan));
                        break;

                    case 5:
                        Console.WriteLine("Program Selesai.");
                        break;

                    default:
                        Console.WriteLine("Pilhan Tidak Tersedia");
                        break;
                }

                if (pilihan != 5)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu...");
                    Console.ReadLine();
                }

            } while (pilihan != 5);

            
        }
    }

}
