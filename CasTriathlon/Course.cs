namespace CasTriathlon
{
    abstract class Course : Epreuve
    {
        public int DeniveleNeg { get; }
        public int DenivelePos { get; }

        public Course(string gpsA, string gpsD, Triathlon leTriathlon, int temperature, int denivelePos, int deniveleNeg) : base(gpsA, gpsD, leTriathlon)
        {
            DenivelePos = denivelePos;
            DeniveleNeg = deniveleNeg;
        }
    }
}