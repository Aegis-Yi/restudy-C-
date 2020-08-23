using System;
class complex {
    private double Re = 0;
    private double Im = 0;
    //定义一个复数
    public complex (double r, double m) {
        Re = r;
        Im = m;
    }
    //两个复数相加
    public complex plus (complex a) {
        double RE = a.Re + this.Re;
        double IM = a.Im + this.Im;
        complex c = new complex (RE, IM);
        c.print ();
        return c;

    }
    //两个复数相减
    public complex Sub (complex a) {
        double RE = this.Re - a.Re;
        double IM = this.Im - a.Im;
        complex c = new complex (RE, IM);
        c.print ();
        return c;
    }
    //两个复数相乘
    public complex Mul (complex a) {
        double RE = a.Re * this.Re - a.Im * this.Im;
        double IM = a.Re * this.Im + a.Im * this.Re;
        complex c = new complex (RE, IM);
        c.print ();
        return c;

    }
    //静态方法
    static public complex operator + (complex a, complex b) {
        double RE = a.Re + b.Re;
        double IM = a.Im + b.Im;
        complex c = new complex (RE, IM);
        c.print ();
        return c;
    }
    static public complex operator - (complex a, complex b) {
        double RE = a.Re - b.Re;
        double IM = a.Im - b.Im;
        complex c = new complex (RE, IM);
        c.print ();
        return c;
    }
    static public complex operator * (complex a, complex b) {
        double RE = a.Re * b.Re - a.Im * b.Im;
        double IM = a.Re * b.Im + a.Im * b.Re;
        complex c = new complex (RE, IM);
        c.print ();
        return c;
    }
    //显示结果
    public void print () {
        if (Re != 0) {
            if (Im > 0)
                Console.WriteLine (Re + "+" + Im + "i");
            if (Im == 0)
                Console.WriteLine (Re);
            if (Im < 0)
                Console.WriteLine (Re + "" + Im + "i");
        } else {
            if (Im != 0)
                Console.WriteLine (Im + "i");
            else
                Console.WriteLine ("0");
        }
    }
}
class Program {
    static void Main (string[] args) {
        complex a = new complex (1, 1);
        complex b = new complex (1, -2);
        complex c = new complex (1, 0);
        complex d = a + b;
        complex e = a - b;
        complex f = a * b;
        d = a.plus (b);
        e = a.Sub (b);
        f = a.Mul (b);
    }
}