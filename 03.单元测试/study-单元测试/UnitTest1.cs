using System;
using Xunit;
using Moq;
using SourceCode;

namespace Demo.Test
{
    public class DeskfanTest
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<Ipower>();
            mock.Setup(power => power.GetPower()).Returns(() => 0);
            //var fan = new Deskfan (new PowerLowerThanZero ());
            var fan = new Deskfan(mock.Object);
            var excepted = "don't work.";
            var actual = fan.Work();
            Assert.Equal(excepted, actual);
        }

        [Fact]
        public void PowerLowerThanZero_boom()
        {
            var fan = new Deskfan(new PowerLowerThanboom());
            var excepted = "boom!!!";
            var actual = fan.Work();
            Assert.Equal(excepted, actual);
        }

        class PowerLowerThanZero : Ipower
        {
            public int GetPower()
            {
                return 0;
            }
        }

        class PowerLowerThanboom : Ipower
        {
            public int GetPower()
            {
                return 300;
            }
        }
    }
}
