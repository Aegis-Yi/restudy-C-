using System;
//*
namespace Generic {
    class Box<TCargo> {
        public TCargo Cargo { get; set; }
    }

    class Book {
        public string Name { get; set; }
    }

    class Apple {
        public string Color { get; set; }
    }

    class Program {
        static void Main (string[] args) {
            Apple apple = new Apple () { Color = "red" };
            Book book = new Book () { Name = "new book" };
            Box<Apple> box1 = new Box<Apple> () { Cargo = apple };
            Box<Book> box2 = new Box<Book> () { Cargo = book };
            Console.WriteLine (box1.Cargo.Color);
            Console.WriteLine (box2.Cargo.Name);
        }
    }   
}
//*/

/*
namespace IoGeneric {
    interface IPeople<Tid> {
        Tid ID { get; set; }
    }

    class Student<Tid> : IPeople<Tid> {
        public Tid ID { get; set; }
        public string Name { get; set; }
    }

    class Program {
        static void Main () {
            Student<int> stu = new Student<int> ();
            stu.ID = 001;
            stu.Name = "LiHua";
            Console.WriteLine ("{0},{1}", stu.ID, stu.Name);
        }
    }
}
//*/

/* 
namespace ArGeneric {
    class Program {
        static void Main () {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] b1 = { 1, 2, 3, 4, 5, 6 };
            double[] a2 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] b2 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            var result = Zip (a1, b1);
            Console.WriteLine (string.Join (",", result));
        }

        static T[] Zip<T> (T[] a, T[] b) {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do {
                if (ai < a.Length) zipped[zi++] = a[ai++];
                if (bi < b.Length) zipped[zi++] = b[bi++];
            } while (ai < a.Length || bi < b.Length);
            return zipped;
        }
    }
} 
//*/

/* 
namespace AcGeneric {
    class Program {
        static void Main () {
            Action<string> a1 = Say;
            a1 ("world");
            Action<int> a2 = Num;
            a2 (1);
        }
        static void Say (string str) {
            Console.WriteLine ($"hello,{str}!");
        }
        static void Num (int x) {
            Console.WriteLine (x * 100);
        }
    }
} 
//*/

/* 
namespace FuncGeneric {
    class Program {
        static void Main () {

            Func<int, int, int> func1 = (a, b) => { return a + b; };
            Func<double, double, double> func2 = (a, b) => { return a + b; };
            var result1 = func1 (100, 220);
            var result2 = func2 (100.1, 220.2);
            Console.WriteLine (result1);
            Console.WriteLine (result2);
        }
    }
} 
//*/