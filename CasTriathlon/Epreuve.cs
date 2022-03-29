namespace CasTriathlon
{
    abstract class Epreuve
    {
        public string GpsD { get; }
        public string GpsA { get; }
        public Triathlon LeTriathlon { get; }
        
        protected Epreuve(string gpsA, string gpsD, Triathlon leTriathlon)
        {
            GpsA = gpsA;
            GpsD = gpsD;
            LeTriathlon = leTriathlon;
        }
    }
}