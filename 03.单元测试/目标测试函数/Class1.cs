using System;

namespace SourceCode
{
    public interface Ipower
    {
        int GetPower();
    }
    public class PowerSupply : Ipower
    {
        public int GetPower() => 100;
    }
    public class Deskfan
    {
        private Ipower _PowGet;
        public Deskfan(Ipower PowGet)
        {
            _PowGet = PowGet;
        }
        public string Work()
        {
            int power = _PowGet.GetPower();
            if (power <= 0)
            {
                return "don't work.";
            }
            else if (power < 100)
            {
                return "work slow.";
            }
            else if (power < 200)
            {
                return "work hight.";
            }
            else
            {
                return "boom!!!";
            }
        }
    }
}
