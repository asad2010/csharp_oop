using System;
using System.Collections.Generic;
namespace first
{
    class Program
    {
    
        static void Main(){
            Robot bot = new Robot("Bot", 800, new byte[] {0,0,0});
            Robot baby = new Robot("Genius", 900, new byte[] {0,0,1});
            Killer killua = new Killer("Killua", 1000, new byte[] {0,1,0}, true, Type.Enemy);
            baby.GetRobotInformation();
            killua.GetRobotInformation();
            
        }

    }
}