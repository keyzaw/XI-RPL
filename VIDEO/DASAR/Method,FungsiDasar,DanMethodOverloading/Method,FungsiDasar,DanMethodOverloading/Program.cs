// Method
static void Salam()
{
    Console.WriteLine("Hello world");
}

// memanggil method tanpa return value dan tanpa parameter
Salam();

// Method Tanpa parameter
static void Sapa(string nama)
{
    Console.WriteLine("Halo " + nama);
}

// Memanggil method dengan parameter sesuai dengan tipe parameter pada method yang kita buat sebelumnya
Sapa("Budi");

// Method dengan Return Value
static int Tambah(int a, int b)
{
    return a + b;
}

// Memanggil method dengan return value
Console.WriteLine(Tambah(5, 7));