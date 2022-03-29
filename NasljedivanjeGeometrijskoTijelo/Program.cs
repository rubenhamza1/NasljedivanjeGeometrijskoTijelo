using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeGeometrijskoTijelo
{
    class GeometrijskoTijelo
    {
        double volumen, oplosje;
        static int brojacTijela;

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }
        public static int BrojacTijela { get => brojacTijela; set => brojacTijela = value; }
    }
    class Kugla : GeometrijskoTijelo
    {

    }
    class Kvadar : GeometrijskoTijelo
    {

    }
    class Kocka : Kvadar
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();

        }
    }
}
