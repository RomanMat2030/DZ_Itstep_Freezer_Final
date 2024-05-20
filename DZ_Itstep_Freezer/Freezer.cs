using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    partial class Freezer
    {
        public override string ToString()
        {
            return $"Model : {Model}\nColor : {Color} \nType freeze : {TypeFreeze}\n Minimal temperature : {MinTemperature}\n Maximum temperature : {MaxTemperature}\nHeight : {Height}cm\nWidth : {Width}cm \nPrice : {Price}$\nCount : {count}";
        }
        static Freezer()
        {
            count = 0;
            TypeFreeze = "dry freeze";

        }
        public Freezer(string Model, string Color, int minTemp, int maxTemp, int h, int w, double p)
        {
            this.Model = Model;
            this.Color = Color;
            MinTemperature = minTemp;
            MaxTemperature = maxTemp;
            Height = h;
            Width = w;
            Price = p;
        }
    }

}
