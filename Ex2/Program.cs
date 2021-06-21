using System;
namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange += heater.OnTemperatureChanged;
            Heater heater2 = new Heater(100);
            thermostat.OnTemperatureChange += heater2.OnTemperatureChanged;
            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange += cooler.OnTemperatureChanged;
            Console.Write("Enter temperature:");
            thermostat.CurrentTemperature = int.Parse(Console.ReadLine());
        }
    }
}