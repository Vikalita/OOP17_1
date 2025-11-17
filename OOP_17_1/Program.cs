using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_17_1
{
    struct Color
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public override string ToString()
        {
            return $"RGB({R}, {G}, {B})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Color(666, 385, 10);
            var c2 = c1; 
            c2.R = 100; 
            Console.WriteLine(c1); 
            Console.WriteLine(c2); 
        }
    }
}

