// Array
string[] namaBuah = { "Apel", "Mangga", "Jeruk" };

// Mengambil Data Array
//Console.WriteLine(namaBuah[0]);
//Console.WriteLine(namaBuah[2]);

// Array juga seringndigunakan bersama dengan perulangan foreach
foreach (string buah in namaBuah)
{
    Console.WriteLine(buah);
}

// koleksi dasar : list

List<string> namaSiswa = new List<string>();

// Menambah data ke list
namaSiswa.Add("Budi");
namaSiswa.Add("Anton");
namaSiswa.Add("Siti");

// Menampilkan hasil dari list
foreach (string siswa in namaSiswa)
{
    Console.WriteLine(siswa);
}