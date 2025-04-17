using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class MountainBike : Bicycle
    {
        private int seatHeight;

        public MountainBike(int seatheight, int speed, int cadence, int gear): base (speed , cadence, gear)
        {
            seatHeight = seatheight;
            
        }
        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
        public int GetSeatHeight()
        {
            return seatHeight;
        }
    }
}
