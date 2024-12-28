using System;
using System.Collections.Generic;
namespace first {
    class Robot : IRun {
        public static int unnamed = 1;
        public static List<string> names = new List<string>();
        private string name = $"unnamed {unnamed}";
        public string Name {
            get => name;
            private set {
                if(names.Contains(value)){
                    throw new ArgumentException("The specified name is already taken.");
   
                }
                name = value;
                names.Add(value);
            }
        }
        private int weight = 800;
        public int Weight {
            get => weight;
            set {
                if(value <= 0){
                    throw new ArgumentException("Weight must be greater than 0.");
             
                }
                weight = value;
            }
        }
        private byte[] coordinates = {0,0,0};
        public byte[] Coordinates {
            get => (byte[])coordinates.Clone();
            set {
                if(value == null || value.Length != 3){
                    throw new ArgumentException("Coordinates must be an array of 3 elements representing x, y, and z.");
                }
                coordinates = (byte[])value.Clone();
            }
        }

        public float speed { get; set; }

        public Robot(string _name, int _weight, byte[] _coordinates) {
            try {
                Name =_name;
                Weight = _weight;
                Coordinates = _coordinates;

                
                unnamed++;
                
                System.Console.WriteLine("Robot Has Been Created!");

            } catch(ArgumentException ex){
                System.Console.WriteLine($"Robot Creation Failed. {ex.Message}");
            }
        }

        public virtual void GetRobotInformation(){
            System.Console.WriteLine($"{this.name}'s weight is {this.weight}");
            System.Console.Write("Coordinates: ");
            foreach(byte coordinate in coordinates){
                System.Console.Write(coordinate + " ");
            }
            System.Console.WriteLine();
        }

        public void RobotRun()
        {
            System.Console.WriteLine("Robot is running");
        }
    }

}