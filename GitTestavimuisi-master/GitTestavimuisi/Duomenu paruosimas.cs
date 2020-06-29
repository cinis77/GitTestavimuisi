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
    class Duomenys: IDuomenys
    {
    int Id {get; set;}
    string Zinute { ger;set;}
    DateTime DuomenuParuosimasLaikas {get;set;}
    

    class Data : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set; }
        DateTime DuomenuParuososLaikas { get; set; }
    }

    class A : IDuomenys
    {
        IDuomenys duomenai;
    }

    interface IKomunikacija
    {
        void Siusti(string zinute);
        string SkaitytiDuomenis();
        void PakartotiPaskutineZinute();
    }
    class Komunikacija : IKomunikacija
    {
    public void PakartotiPaskutineZinute()
    {
    }
    public void Siusti (string zinute)
    {
    }
    public string SkaitytiDuomenis()
    {
    return "a";
    }
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

    class B : IKomunikacija
    {}

    interface IDuomenu_paruosimas
    {
        List<IDuomenys> Data { get; }

        string SukurtiDuomenuEilute(IDuomenys duomuo);

        void PridetiDuomeni(IDuomenys duomuo);

        void SiustiPirmaDuomeni();

        void SiustiDuomeni(int kelintas);

        void SiustiPaskutinDuomeni();
    }
