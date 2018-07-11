using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessStartTest
{
    public class TimeStamp
    {
       public double Timestamp;
        public double joy;
        public double fear;
        public double disgust;
        public double sadness;
        public double anger;
        public double surprise;
        public double contempt;

        public TimeStamp(string Timestamp, string joy, string fear, string disgust, string sadness, string anger, string surprise, string contempt)
        {
            
            try
            {
                this.Timestamp = Convert.ToDouble(Timestamp);
                this.joy = Convert.ToDouble(joy);
                this.fear = Convert.ToDouble(fear);
                this.disgust = Convert.ToDouble(disgust);
                this.sadness = Convert.ToDouble(sadness);
                this.anger = Convert.ToDouble(anger);
                this.surprise = Convert.ToDouble(surprise);
                this.contempt = Convert.ToDouble(contempt);
            }
            catch(Exception e)
            {
                
                this.joy = 0;
                this.fear = 0;
                this.disgust = 0;
                this.anger = 0;
                this.sadness = 0;
                this.surprise = 0;
                this.contempt = 0;
            }
        }
    }
}
