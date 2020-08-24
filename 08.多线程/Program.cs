using System;
using System.Threading;
using System.Threading.Tasks;

namespace _08.多线程 {
    class Program {
        static void Main (string[] args) {
            var task = new Task (() => {
                System.Console.WriteLine ("我是taskbegin...");
                Thread.Sleep (2000);
                Console.WriteLine ("我是taskend...");
            });         

            Task task1 = new Task (() => { Console.WriteLine ($"hello, task 1的线程ID为{Thread.CurrentThread.ManagedThreadId}"); });
            task1.Start ();
            task1.Wait();

            Task task2 = Task.Run (() => { Console.WriteLine ($"hello, task 2的线程ID为{Thread.CurrentThread.ManagedThreadId}"); });

            Task task3 = Task.Factory.StartNew (() => { Console.WriteLine ($"hello,task 3的线程ID为{Thread.CurrentThread.ManagedThreadId}"); });
            
            Console.ReadLine ();
        }
    }
}
