using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestavimuisi
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Duomenys : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set ; }
        public DateTime DuomenuParuososLaikas { get; set ; }
    }
    class Komunikacija : IKomunikacija
    {
        public void PakartotiPaskutineZinute()
        {
            
        }

        public void Siusti(string zinute)
        {
            
        }

        public string SkaitytiDuomenis { get; }
    }
    class Duomenuparuosimas : IDuomenu_paruosimas
    {
        public List<IDuomenys> Data { get; }

        public void PridetiDuomeni(IDuomenys duomuo)
        {
           
        }

        public void SiustiDuomeni(int kelintas)
        {
           
        }

        public void SiustiPaskutinDuomeni()
        {
           
        }

        public void SiustiPirmaDuomeni()
        {
           
        }

        public string SukurtiDuomenuEilute(IDuomenys duomuo)
        {
            throw new NotImplementedException();
        }
    }
}
