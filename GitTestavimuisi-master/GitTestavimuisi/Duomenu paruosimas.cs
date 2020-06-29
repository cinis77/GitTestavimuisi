using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestavimuisi
{
    interface IDuomenys
    {
        int Id { get; set; }
        string Zinute { get; set; }
        DateTime DuomenuParuososLaikas { get; set; }

    }

    class Data : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set; }
        DateTime DuomenuParuososLaikas { get; set; }
    }

    interface IKomunikacija
    {
        void Siusti(string zinute);
        string SkaitytiDuomenis();
        void PakartotiPaskutineZinute();
    }

    class Communication : IKomunikacija
    {
        public void Siusti(string zinute)
        {
            Console.WriteLine(zinute);
        }

        public string SkaitytiDuomenis()
        {
            return "string";
        }

        public void PakartotiPaskutineZinute()
        {
            Console.WriteLine("Paskutine zinute");
        }
    }

    interface IDuomenu_paruosimas
    {
        List<IDuomenys> Data { get; }

        string SukurtiDuomenuEilute(IDuomenys duomuo);

        void PridetiDuomeni(IDuomenys duomuo);

        void SiustiPirmaDuomeni();

        void SiustiDuomeni(int kelintas);

        void SiustiPaskutinDuomeni();
    }

    class Data2: IDuomenu_paruosimas
    {
        public List<IDuomenys> Data { get; }

        public string SukurtiDuomenuEilute(IDuomenys duomuo)
        {
            return "string";
        }

        public void PridetiDuomeni(IDuomenys duomuo)
        {
            Console.WriteLine("blahblahblah");
        }

        public void SiustiPirmaDuomeni()
        {
            Console.WriteLine("Issiustas");
        }

        public void SiustiDuomeni(int kelintas)
        {
            Console.WriteLine("blahblah");
        }

        public void SiustiPaskutiniDuomeni()
        {
            Console.WriteLine("Blahblah");
        }
    }
}
