using System;

delegate void newdelegate ();

namespace _06.委托 {
    class Program {
        public static void todosomething () {
            System.Console.WriteLine ("我是委托");
        }
        static void Main (string[] args) {
            newdelegate dosomething = new newdelegate (todosomething);
            dosomething ();
        }
    }
}
