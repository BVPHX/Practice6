using System;

namespace Triad
{
    public class Triads
    {
        int _first;
        int _second;
        int _third;

        public Triads()
        {
            Random rnd = new Random();
            _first = rnd.Next(0, 10);
            _second = rnd.Next(0, 10);
            _third = rnd.Next(0, 10);
        }

        public int First { get { return _first; } set { _first = value; } }
        public int Second { get { return _second; } set { _second = value; } }
        public int Third { get { return _third; } set { _third = value; } }

        public static bool operator >(Triads firstTriad,Triads secondTriad)
        {
           if (firstTriad.First > secondTriad.First && firstTriad.Second > secondTriad.Second && firstTriad.Third > secondTriad.Third) return true;
            else return false;
        }
        public static bool operator <(Triads firstTriad, Triads secondTriad)
        {
            if (firstTriad.First < secondTriad.First && firstTriad.Second < secondTriad.Second && firstTriad.Third < secondTriad.Third) return true;
            else return false;
        }

        public void IncreaseTriadValuesTo10()
        {
            _first += 10;
            _second += 10;
            _third += 10;
        }
    }
   
}
