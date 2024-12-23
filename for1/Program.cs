using System;

class Program
{
    static void Main(string[] args)
    {
        //
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        Console.Write(); // Bir satır boşluk bırak

        // 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırma
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i);
        }

        Console.Write(); // Bir satır boşluk bırak

        // 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırma.
        for (int i = 2; i <= 20; i += 2) // Sadece çift sayılardan başlatarak yazdırıyoruz
        {
            Console.Write(i);
        }

        Console.Write(); // Bir satır boşluk bırak

        // 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırma.
        int toplam = 0;
        for (int i = 50; i <= 150; i++)
        {
            toplam += i; // Her adımda sayıları topluyoruz
        }
        Console.Write($"50 ile 150 arasındaki sayıların toplamı: {toplam}");

        Console.WriteL(); // Bir satır boşluk bırak

        // 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırma.
        int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 == 0) // Çift sayı kontrolü
            {
                ciftToplam += i;
            }
            else // Tek sayı kontrolü
            {
                tekToplam += i;
            }
        }

        Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
        Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");
    }
}
