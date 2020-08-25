using System;

namespace _09.接口隔离 {
    interface IVehicle {
        void run ();
    }

    interface ITank : IVehicle {
        void fire ();
    }

    class Car : IVehicle {
        public void run () {
            System.Console.WriteLine ("Car is running...");
        }
    }

    class Trunk : IVehicle {
        public void run () {
            System.Console.WriteLine ("Trunk is running...");
        }
    }

    class LightTank : ITank {
        public void run () {
            System.Console.WriteLine ("LightTank is running...");
        }

        public void fire () {
            System.Console.WriteLine ("boom!!!");
        }
    }
    class MidTank : ITank {
        public void run () {
            System.Console.WriteLine ("MidTank is running...");
        }

        public void fire () {
            System.Console.WriteLine ("boom!!!boom!!!");
        }
    }
    class HeavyTank : ITank {
        public void run () {
            System.Console.WriteLine ("HeavyTank is running...");
        }

        public void fire () {
            System.Console.WriteLine ("boom!!!boom!!!boom!!!");
        }
    }

    class Driver {
        private IVehicle _vehicle;

        public Driver (IVehicle _vehicle) {
            this._vehicle = _vehicle;
        }
        public void drive () {
            this._vehicle.run ();
        }

    }
    class Program {
        static void Main (string[] args) {
            new Driver (new Car ()).drive ();
            new Driver (new LightTank ()).drive ();
        }
    }
}
