using System;
namespace first
{
    class Program
    {
        
        static void Main(){
            Robot bot = new Robot("Bot", 800, new byte[] {0,0,0});
            Robot baby = new Robot("Genius", 900, new byte[] {0,0,1});
            Robot killua = new Killer("Killua", 1000, new byte[] {0,1,0}, true);
            foreach(string name in Robot.names){
                Console.WriteLine(name);
            }
        }

    }
}