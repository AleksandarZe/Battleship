using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Ship
    {
        string _position;
        int _duzina;
        SmerBroda _smer;

        public SmerBroda Smer { get { return _smer; } }

        public string Position
        {
            get { return _position; }
        }

        public int Duzina { get { return _duzina; } }

        public Ship(string pozicija, int duzina, SmerBroda smer)
        {
            _position = pozicija;
            _duzina = duzina;
            _smer = smer;
        }
    }

    public enum SmerBroda
    {
        Gore,
        Dole,
        Levo,
        Desno
    }
}
