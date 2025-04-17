using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Bicycle
    {
        protected int speed;
        protected int cadence;
        protected int gear;

        public Bicycle(int speed , int cadence , int gear)
        {
            this.speed = speed;
            this.cadence = cadence;
            this.gear = gear;
            
        }
        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;

        }
        public void ApplyBreak(int decrement)
        {
            speed = speed -decrement;
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public int getspeed()
        {
            return speed;
        }
    }
}
