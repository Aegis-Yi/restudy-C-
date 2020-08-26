using System;

namespace _10.位操作 {
    class Program {
        static void Main (string[] args) {
            int a = 6 & 3; // 6的2进制码为00000110; 3的2进制码为00000011 '&'为逻辑与
            System.Console.WriteLine (a); // a=2(00000010)
            
            int b = 6 | 3; // '|'为或运算
            System.Console.WriteLine (b); // b=7(00000111)
            
            int c = ~6; // '~'为非运算
            System.Console.WriteLine (c); // c=7(11111001)
            
            int d = 6 ^ 3; // '^'为异或运算
            System.Console.WriteLine (d); // d=5(00000101)
            
            int e = 6 << 3; // '<<'为左移
            System.Console.WriteLine (e); // e=48(00101000)
            
            int f = 6 >> 2; // '>>'为右移
            System.Console.WriteLine (f); // f=1(00000001)
        }
    }
}
