using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    partial class Freezer
    {
        //private int minTemperature;
        //private int maxTemperature;
        //private int height;
        //private int width;
        //private string model;
        private int capacity;
        //private string color;
        public string Model { get; set; }
        public string Color { get; set; }

        private int minTemperature;

        public int MinTemperature
        {
            get { return minTemperature; }
            set
            {
                if (value > -7 && value < 0)
                {
                    minTemperature = value;
                }
                else
                {
                    minTemperature = 0;
                }
            }
        }
        private int maxTemperature;

        public int MaxTemperature
        {
            get { return maxTemperature; }
            set
            {
                if (value > 0)
                {
                    maxTemperature = value;
                }
                else
                {
                    maxTemperature = 0;
                }
            }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = 0;
                }

            }
        }
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    width = 0;
                }
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }



        private static int count;
        private static string TypeFreeze;
        // private static int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[5];

            freezers[0] = new Freezer("Samsung", "White", -3, 15, 200, 50, 800);
            freezers[1] = new Freezer("Xiaomi", "Black", -9, 23, 190, 50, 300);
            freezers[2] = new Freezer("LG", "White", -20, 10, 210, 62, 660);
            freezers[3] = new Freezer("Fuflo", "Brown", -6, 22, 150, 50, 150);
            freezers[4] = new Freezer("ChinaTowm", "White", -1, 29, 165, 50, 250);

            foreach (var friz in freezers)
            {
                Console.WriteLine(friz);
                Console.WriteLine("----------------");
            }
        }
    }
}