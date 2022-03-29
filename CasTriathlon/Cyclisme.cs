namespace CasTriathlon
{
    class Cyclisme : Course
    {
        
        public Cyclisme(string gpsA, string gpsD, Triathlon leTriathlon, int temperature, int denivelePos, int deniveleNeg) : base(gpsA, gpsD, leTriathlon, temperature, denivelePos, deniveleNeg)
        {
            
        }
    }
}