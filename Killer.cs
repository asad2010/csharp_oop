using System;

namespace first {
    enum Type { Enemy, Hero, Impostor };

    class Killer : Robot  {
        private bool hasLasers = false;
        private Type type;
    
        public bool HasLasers {
            get => hasLasers;
            set => hasLasers = value;
        }

        public Killer(string _name, int _weight, byte[] _coordinates, bool _hasLasers, Type _type): base(_name, _weight, _coordinates){
            this.type = _type;
            HasLasers = _hasLasers;
        }

        public override void GetRobotInformation()
        {
            base.GetRobotInformation();

            System.Console.WriteLine($"{this.Name}'s Type Is {this.type}");
        }

    }
}