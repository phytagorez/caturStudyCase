using System;

namespace PermainanCatur
{
    public class BidakCatur
    {
        public virtual void Bergerak(int jarak, string arah)
        {
            Console.WriteLine($"Bidak bergerak sejauh {jarak} petak ke arah {arah}.");
        }

        public virtual void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Bidak memakan {bidakLawan} di petak {petak}.");
        }
    }

    public class Pion : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak > 2)
            {
                Console.WriteLine($"Pion gagal bergerak: Tidak bisa maju lebih dari 2 petak (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Pion maju sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Pion memakan {bidakLawan} secara diagonal ke depan di petak {petak}.");
        }
    }

    public class Benteng : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak > 8)
            {
                Console.WriteLine($"Benteng gagal bergerak: Papan catur hanya 8x8 petak (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Benteng bergerak lurus sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Benteng memakan {bidakLawan} dalam garis lurus di petak {petak}.");
        }
    }

    public class Kuda : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak != 3)
            {
                Console.WriteLine($"Kuda gagal bergerak: Kuda harus melompat sejauh 3 petak (huruf 'L') (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Kuda melompat membentuk huruf 'L' sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Kuda memakan {bidakLawan} di akhir lompatan 'L' di petak {petak}.");
        }
    }

    public class Gajah : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak > 8)
            {
                Console.WriteLine($"Gajah gagal bergerak: Jarak maksimal hanya 8 petak (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Gajah bergerak menyilang (diagonal) sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Gajah memakan {bidakLawan} dalam jalur menyilang di petak {petak}.");
        }
    }

    public class Menteri : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak > 8)
            {
                Console.WriteLine($"Menteri gagal bergerak: Langkah tidak boleh melebihi 8 petak (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Menteri bergerak sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Menteri memakan {bidakLawan} dari jarak jauh secara lurus atau menyilang di petak {petak}.");
        }
    }

    public class Raja : BidakCatur
    {
        public override void Bergerak(int jarak, string arah)
        {
            if (jarak > 1)
            {
                Console.WriteLine($"Raja gagal bergerak: Raja hanya bisa bergeser 1 petak (Mencoba {jarak} petak ke {arah})!");
                return;
            }
            Console.WriteLine($"Raja pindah sejauh {jarak} petak ke arah {arah}.");
        }

        public override void Makan(string bidakLawan, string petak)
        {
            Console.WriteLine($"Raja memakan {bidakLawan} yang berada 1 petak di sekitarnya di petak {petak}.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            BidakCatur kudaPutih = new Kuda();
            BidakCatur menteriHitam = new Menteri();
            BidakCatur pionPutih = new Pion();
            BidakCatur bentengHitam = new Benteng();

            Console.WriteLine("=== LANGKAH VALID ===");
            kudaPutih.Bergerak(3, "A1");
            pionPutih.Bergerak(2, "depan");

            Console.WriteLine("\n=== LANGKAH TIDAK VALID ===");
            bentengHitam.Bergerak(10, "E10");

            Console.WriteLine("\n=== SIMULASI MAKAN ===");
            bentengHitam.Makan("Gajah Putih", "A8");
        }
    }
}