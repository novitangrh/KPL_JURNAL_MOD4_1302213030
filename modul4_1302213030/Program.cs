// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

internal class KodeBuah
{
    private string[] buah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", 
        "Ceri", "Kelapa", "Jagung","Kurma", "Durian", "Anggur", "Melon", "Semangka"};
    private string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", 
        "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

    public string getKodeBuah(string fruit)
    {
        for(int i = 0; i < buah.Length; i++)
        {
            if (buah[i] == fruit)
            {
                return "Kode buah: " + kode[i];
            }
        }
        return "Buah tidak tesedia";
    }
}

class Program
{
    public static void Main(string[] agrs)
    {
        KodeBuah kode = new KodeBuah();
        Console.Write("Nama buah: ");
        string buah = Console.ReadLine();
        Console.WriteLine(kode.getKodeBuah(buah));
    }
}
