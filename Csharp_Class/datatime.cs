using System;
//定义一个长方形的类
class Cub3 {
    private double L = 0;
    private double W = 0;
    private double H = 0;
    private double S = 0;
    private double V = 0;
    public Cub3 (double l, double w, double h) {
        L = l;
        W = w;
        H = h;
    }
    //定义一个长方形的面积计算方法
    public void Cub3S () {
        S = (L * W + L * H + W * H) * 2;
        Console.WriteLine ("长方形的面积:" + S);
    }
    //定义一个长方形体积的计算方法
    public void Cub3V () {
        V = L * W * H;
        Console.WriteLine ("长方形的体积是:" + V);
    }
}
//设计一个日期类
class DataTime {
    private int Year = 0;
    private int Mouth = 0;
    private int Day = 0;
    public DataTime (int y, int m, int d) {
        Year = y;
        Mouth = m;
        Day = d;
    }
    //设计一个月份天数计算
    public void DayNum (int y, int m) {
        int Day = 31;
        if (m == 2) {
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
                Day = 29;
            else
                Day = 28;
        }
        if (m == 4 || m == 6 || m == 9 || m == 11)
            Day = 30;
        Console.WriteLine ("{0}月的天数为{1}天", m, Day);
    }
    //计算天数
    public int DateNum () {
        int num = 0;
        for (int mouth = 1; mouth < this.Mouth; mouth++) {
            if (mouth == 2) {
                if ((this.Year % 4 == 0 && this.Year % 100 != 0 && this.Year != 0) || (this.Year % 400 == 0 && this.Year != 0))
                    num += 29;
                else
                    num += 28;
            } else {
                if (mouth == 4 || mouth == 6 || mouth == 9 || mouth == 11) {
                    num += 30;
                } else
                    num += 31;
            }
        }
        return num + Day;
    }
    public int GetDate () {
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < this.Year; i++) {
            if ((i % 4 == 0 && i % 100 != 0 && i != 0) || (i % 400 == 0 && i != 0))
                sum1 += 366;
            else
                sum1 += 365;
        }
        sum2 = this.DateNum () + sum1;
        return sum2;
    }
    public DataTime plus (int n) {
        int a = this.GetDate () + n;
        int y = 0;
        int m = 1;
        int d = 1; //计算是从0.1.1开始
        for (int i = a; i > 0;) { //通过计算月数.总计过去的天数
            d = i;
            if (m == 2) {
                if ((y % 4 == 0 && y % 100 != 0 && y != 0) || (y % 400 == 0 && y != 0))
                    i -= 29;
                else
                    i -= 28;
            } else {
                if (m == 4 || m == 6 || m == 9 || m == 11) {
                    i -= 30;
                } else
                    i -= 31; //减去每月的固定天数,
            }
            if (i > 0)
                m++; //若i不为负就进行m++,到下一个月
            if (m == 13) {
                y++;
                m = 1; //当m==13时,也就是12月过完,进入一月
            }
        }
        Console.WriteLine ("{0}.{1}.{2}加上{3}天是{4}.{5}.{6}", Year, Mouth, Day, n, y, m, d);
        DataTime c = new DataTime (y, m, d);
        return c;
    }
    //两个日期之差
    static public int operator - (DataTime a, DataTime b) {
        int sum1 = 0;
        int sum2 = 0;
        DataTime c = new DataTime (0, 0, 0);
        if (a.Year < b.Year) {
            c = b;
            b = a;
            a = c;
        }
        for (int i = b.Year; i < a.Year; i++) {
            if ((i % 4 == 0 && i % 100 != 0 && i != 0) || (i % 400 == 0 && i != 0))
                sum1 += 366;
            else
                sum1 += 365;
        }
        sum2 = a.DateNum () - b.DateNum () + sum1;
        return sum2;
    }
    //星期运算
    public void Week () {
        int sum = this.GetDate () - 1;
        int week = sum % 7;
        if (week == 0)
            week = 7;
        Console.WriteLine ("{0}.{1}.{2}是星期{3}", this.Year, this.Mouth, this.Day, week);
    }
}

class Program {
    static void Main () {
        Cub3 C = new Cub3 (1, 2, 3);
        C.Cub3S ();
        C.Cub3V ();
        DataTime a = new DataTime (2007, 6, 6);
        DataTime b = new DataTime (2008, 6, 6);
        DataTime t = new DataTime (2019, 4, 10);
        int c = a - b;
        int n = t.GetDate ();
        Console.WriteLine (c);
        a.plus (366);
        t.Week ();
    }
}