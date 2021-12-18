using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Адрес здания: ");
            string adress = Console.ReadLine();

            Console.WriteLine("Длина здания: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ширина здания: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Высота здания: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Этаж здания: ");
            int level = Convert.ToInt32(Console.ReadLine());

            Building building1 = new Building(adress, length, width, height);

            MultiBuildig multiBuildig1 = new MultiBuildig(adress, length, width, height, level);

            multiBuildig1.Print();
            Console.ReadKey();


        }
    }

    public class Building
    {
        string adress { get; set; }
        double length { get; set; }
        double width { get; set; }
        double height { get; set; }

        public Building(string adr, double len, double wid, double hei)
        {
            this.adress = adr;
            this.length = len;
            this.width = wid;
            this.height = hei;
        }

        public void Print()
        {
            Console.WriteLine("Здание по адресу: {0}\nДлина: {1}\nШирина: {2}\nВысота: {3}", this.adress, this.length, this.width, this.height);
        }
    }

    sealed class MultiBuildig : Building
    {
        public int level { get; set; }
        public MultiBuildig(string adr, double len, double wid, double hei, int lev) : base(adr, len, wid, hei)
        {
            this.level = lev;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этаж здания: {0}", this.level);
        }


    }


}