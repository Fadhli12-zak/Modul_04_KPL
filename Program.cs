using System;

class KodeProduk {
    String[] produkElektronik = { "Laptop", "SmartPhone", "Tablet", "Headset", "keyboard ", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera" };
    String[] kodeProduk = { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

    public string getKodeProduk(string produk)
    {
        for (int i = 0; i < produkElektronik.Length; i++)
        {
            if (produkElektronik[i].Equals(produk, StringComparison.OrdinalIgnoreCase))
            {
                return kodeProduk[i];
            }
        }
        return null;
    }
}

class MainProgram {
    public static void Main(String[] args) {
        KodeProduk kodeProduk = new KodeProduk();   
        string input = null;
        while (input != "exit")
        {
            Console.WriteLine("Masukkan nama produk elektronik: ");
            input = Console.ReadLine();
            String Search = kodeProduk.getKodeProduk(input);
            if (Search != null)
            {
                Console.WriteLine("Kode produk: " + input + " adalah " + Search);
            }
            else { 
                Console.WriteLine("Produk tidak ditemukan");
            }
        }

    } 
    
}