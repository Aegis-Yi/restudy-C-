using System;
class datetime {
    static void Main (string[] args) {
        int sum = 0;
        for (int i = 2008; i < 2018; i++) {
            if (i % 4 == 0)
                sum += 366;
            else
                sum += 365;
        }
        Console.WriteLine (sum + date (2018, 3, 12) - date (2008, 8, 8));
    }
    public static int date(int y, int m, int d) {
        int sum = 0;
        for (int mouth = 1; mouth < m; mouth++) {
            switch (mouth) {
                case 2:
                    if (y % 4 == 0)
                        sum += 29;
                    else
                        sum += 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    sum += 30;
                    break;
                default:
                    sum += 31;
                    break;
            }
        }
        return sum + d;
    }
}