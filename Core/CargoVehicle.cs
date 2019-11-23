using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CargoVehicle
    {
        string plate;
        byte speed;
        string model;

        public delegate void SpeedHandler(object item);
        public event SpeedHandler SpeedExceeded;
        public CargoVehicle(string plate, string model)
        {
            this.plate = plate;
            this.model = model;
        }
        public string Model { get => model;  }
        public byte Speed 
        { 
            get => speed; 
            set { 
                speed = value;
                if (speed>110)
                {
                    //Event Tetikledim
                    //Event Argümanlarına şuanki hızı yükledim ve bu nesneyi kullanılması bu nesneyide yolladım
                    SpeedExceeded(this);
                }
            } 
        }
        public string Plate { get => plate;  }
    }
}
