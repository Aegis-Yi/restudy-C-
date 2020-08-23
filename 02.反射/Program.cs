using System;
using Microsoft.Extensions.DependencyInjection;

interface Iop {
    void Test ();
}

class op1 : Iop {
    public void Test () => Console.WriteLine ("hello");
}
class op2 : Iop {
    public void Test () => Console.WriteLine ("world");
}
class op {
    private Iop _op;
    public op (Iop Op) => _op = Op;
    public void optest () => _op.Test ();
}

class Program
{
    static void Main(string[] args)
    {
        var sc = new ServiceCollection();
        sc.AddScoped(typeof(Iop), typeof(op1));
        sc.AddScoped<op>();
        var sp = sc.BuildServiceProvider();
        //==================================//
        var a = sp.GetService<op>();
        a.optest();
    }
}