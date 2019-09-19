using System;

namespace QUIZ09092019
{

    class BangunDatar
    {
        public void luas_persegi()
        {
            Console.WriteLine("Menghitung luas persegi");
            Console.WriteLine("-----------------------");

            int sisi;
            Console.WriteLine("Masukkan nilai sisi");
            sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("Luas persegi adalah "+luas);
        }

        public void luas_segitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("------------------------");

            int alas,tinggi,a,b,z,luas;
            Console.WriteLine("Masukkan nilai alas");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai tinggi");
            tinggi = Convert.ToInt32(Console.ReadLine());

            a = 1;
            b = 2;

            z = a * alas * tinggi;
            luas = z / b;

            Console.WriteLine("Luas Segitiga adalah "+luas);
        }

        public void luas_lingkaran ()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine("-------------------------");

            int r,a,b,blmjadi,luas;

            a = 22;
            b = 7;

             Console.WriteLine("Masukkan nilai ruas");
             r = Convert.ToInt32(Console.ReadLine());

             blmjadi = a * r * r;
             luas = blmjadi / b;

             Console.WriteLine("Luas Lingkaran adalah "+luas);
        }
    }
}