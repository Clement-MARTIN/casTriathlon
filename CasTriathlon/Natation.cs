namespace CasTriathlon
{
    class Natation : Epreuve
    {
        public int Temperature { get; }

        public Natation(string gpsA, string gpsD, Triathlon leTriathlon, int temperature) : base(gpsA, gpsD, leTriathlon)
        {
            Temperature = temperature;
        }
    }
}