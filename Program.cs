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
            else
            {
                Console.WriteLine("Produk tidak ditemukan");
            }
        }
        FanLaptop fanLaptop = new FanLaptop();
        fanLaptop.FanMod();
    } 
}
class FanLaptop
{
    enum State { QUIET, BALANCED, PERFORMANCE, TURBO };
    public void FanMod()
    {
        State state = State.QUIET;
        string command = null;
        while (command != "exit") { 
            Console.WriteLine("Masukkan perintah: ");
            command = Console.ReadLine();
            switch (state)
            {
                case State.QUIET:
                    if (command == "Mode Up")
                    {
                        state = State.BALANCED;
                        Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    }
                    else if (command == "Turbo Shortcut")
                    {
                        state = State.TURBO;
                        Console.WriteLine("Fan Quiet Berubah menjadi turbo");
                    }
                    break;
                case State.BALANCED:
                    if (command == "Mode Up")
                    {
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan Balance berubah menjadi Performance");
                    }
                    else if (command == "Mode Down")
                    {
                        state = State.QUIET;
                        Console.WriteLine("Fan Balance berubah menjadi quiet");
                    }
                    break;
                case State.PERFORMANCE:
                    if (command == "Mode Up")
                    {
                        state = State.TURBO;
                        Console.WriteLine("Fan performance berubah menjadi turbo");
                    }
                    else if (command == "Mode Down")
                    {
                        state = State.BALANCED;
                        Console.WriteLine("Fan performance berubah menjadi balance");
                    }
                    break;
                case State.TURBO:
                    if (command == "Mode Down")
                    {
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan turbo Berubah menjadi performance");
                    }else if (command == "Turbo Shortcut")
                    {
                        state = State.QUIET;
                        Console.WriteLine("Fan turbo Berubah menjadi Quiet");
                    }
                    break;
            }
        }

    }
}
 