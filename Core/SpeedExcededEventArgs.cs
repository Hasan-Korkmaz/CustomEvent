using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class SpeedExcededEventArgs:EventArgs
    {
        byte speed;
        public SpeedExcededEventArgs(byte speed)
        {
            this.speed = speed;
        }
        public byte Speed { get => speed; }
    }
}
