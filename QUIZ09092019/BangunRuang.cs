using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volume_balok()
        {
            Console.WriteLine("Menghitung volume balok");
            Console.WriteLine("-----------------------");

            int p,l,t,volume;

            Console.WriteLine("Masukkan nilai panjang :");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai lebar :");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai tinggi :");
            t = Convert.ToInt32(Console.ReadLine());

            volume = p * l * t;

            Console.WriteLine("Volume Balok adalah "+volume);
        }

        public void volume_kubus ()
        {
            Console.WriteLine("Menghitung volume kubus");
            Console.WriteLine("-----------------------");

            int sisi, volume;

            Console.WriteLine("Masukkan nilai sisi :");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi;

            Console.WriteLine("Jadi Volume kubus adalah "+volume);
        }
    }
}