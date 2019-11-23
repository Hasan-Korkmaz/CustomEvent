using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core;

namespace Tester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Core.CargoVehicle cargoVehicle;
            Core.CargoVehicle cargoVehicle2;
            cargoVehicle = new Core.CargoVehicle("42ER910", "AUDİ");
            cargoVehicle2 = new Core.CargoVehicle("15HP181", "BMW");
            //Event Tetiklendiğinde Handlerin Gösterdiği fonsiyonu çalıştır
            //Handler Yerine Doğrudan Bir Method Verilebilirdi
            //
            cargoVehicle.SpeedExceeded += new Core.CargoVehicle.SpeedHandler(Logger);
            cargoVehicle2.SpeedExceeded += new Core.CargoVehicle.SpeedHandler(Logger);
            byte j = 3;
            for (byte i = 80; i < 130; i += 5)
            {
                cargoVehicle.Speed = i;
                cargoVehicle2.Speed = (byte)(i + j);
                Console.WriteLine(cargoVehicle.Plate + " plakalı aracın hızı : " + cargoVehicle.Speed+" km/h");
                Console.WriteLine(cargoVehicle2.Plate + " plakalı aracın hızı : " + cargoVehicle2.Speed+" km/h");
                Console.WriteLine(Environment.NewLine);
                Thread.Sleep(1000);
               
            }
            Console.ReadKey();

        }
       static void Logger(object item)
        {
            Core.CargoVehicle temCargoVehicle = (Core.CargoVehicle)item;
            Console.WriteLine("Hız Aşımı...!  "+ temCargoVehicle.Plate + " plakalı aracın hızı : " +temCargoVehicle.Model +" marka aracı hız limitini aştı."+DateTime.Now+" anındaki hızı :" + temCargoVehicle.Speed + " km/h");

        }
    }
}
