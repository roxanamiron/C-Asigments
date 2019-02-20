using System;

namespace Programing14
{
    public class Battery
    {
        public enum BatteryType
        {
            LiIon,NiMH,NiCD

        }

        private string Model { get; set; }
        private int IdleTime { get; set; }
        private int HoursTalk { get; set; }

       public void Display()
        {
            Console.WriteLine(BatteryType.LiIon);
        }
    }
}