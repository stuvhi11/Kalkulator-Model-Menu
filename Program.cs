// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
        string ulang = "";
        do
        {
            Console.WriteLine("Selamat Datang di Perhitungan");
            Console.WriteLine("\t=====Menu=====");
            Console.WriteLine("\t1.Penjumlahan\n\t2.Pengurangan\n\t3.Perkalian\n\t4.Pembagian");
            Console.WriteLine("\t==============");
            Console.WriteLine("Noted : Isi berupa angka 1/2/3/4");
            Console.Write("Ingin melakukan perhitungan menu ke berapa? ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.Write("Masukkan angka pertama = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua = ");
                    int aa = Convert.ToInt32(Console.ReadLine());
                    int addition = a + aa;
                    Console.WriteLine($"Hasil Penjumlahan = {addition}");
                    break;
                case 2:
                    Console.Write("Masukkan angka pertama = ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua = ");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    int subtraction = a1 - a2;
                    Console.WriteLine($"Hasil Pengurangan = {subtraction}");
                    break;
                case 3:
                    Console.Write("Masukkan angka pertama = ");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua = ");
                    int a4 = Convert.ToInt32(Console.ReadLine());
                    int multiplication = a3 * a4;
                    Console.WriteLine($"Hasil Perkalian = {multiplication}");
                    break;
                case 4:
                    Console.Write("Masukkan angka pertama = ");
                    int a5 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Masukkan angka kedua = ");
                    int a6 = Convert.ToInt32(Console.ReadLine());
                    int division = a5 / a6;
                    Console.WriteLine($"Hasil Pembagian = {division}");
                    break;
                default:
                    Console.WriteLine("     ^^Maaf menu yang ada pilih tidak tersedia^^");
                    Console.WriteLine("Terimakasih telah menggunakan program perhitungan ini\n\t\tHave a nice day!!");
                    break;
            }
            Console.WriteLine("Apakah anda ingin mengulangi atau melakukan perhitungan lagi?");
            Console.WriteLine("Noted jawab ya/tidak");
            ulang = Console.ReadLine();
        } while (ulang == "ya");
        Console.WriteLine("\nTerimakasih telah melakukan program perhitungan ini\n\t\tHave a nice day!!");
    }
}