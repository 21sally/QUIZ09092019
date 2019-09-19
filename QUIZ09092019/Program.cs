using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();

            obj.luas_persegi();
            obj.luas_segitiga();
            obj.luas_lingkaran();

            BangunRuang tes = new BangunRuang();

            tes.volume_balok();
            tes.volume_kubus();
        }
    }
}
