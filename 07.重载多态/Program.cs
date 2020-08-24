using System;

namespace _07.重载多态 {
    class CongZai {
        public void print (string i) {
            System.Console.WriteLine ("这是个字符串");
        }
        public void print (int i) {
            System.Console.WriteLine ("这是个int型");
        }
        public void print (double i) {
            System.Console.WriteLine ("这是个double型");
        }
    }
    class Program {
        static void Main (string[] args) {
            CongZai test = new CongZai ();
            int i = 0;
            double j = 0.0;
            string k = "'0'";
            test.print (i);
            test.print (j);
            test.print (k);
        }
    }
}
