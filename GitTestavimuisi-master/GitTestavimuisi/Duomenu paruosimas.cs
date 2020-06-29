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

    



    class Komun : IKomunikacija
    {
        public void PakartotiPaskutineZinute()
        {
            throw new NotImplementedException();
        }

        public void Siusti(string zinute)
        {
            throw new NotImplementedException();
        }

        public string SkaitytiDuomenis()
        {
            throw new NotImplementedException();
        }
    }
    class Duomen : IDuomenys
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Zinute { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DuomenuParuososLaikas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class DuomenParuos : IDuomenu_paruosimas
    {
        public List<IDuomenys> Data => throw new NotImplementedException();

        public void PridetiDuomeni(IDuomenys duomuo)
        {
            throw new NotImplementedException();

        }

        public void SiustiDuomeni(int kelintas)
        {

            Console.WriteLine("blahblah");
        }

        public void SiustiPaskutiniDuomeni()
        {
            Console.WriteLine("Blahblah");
        }

            throw new NotImplementedException();
        }

        public void SiustiPaskutinDuomeni()
        {
            throw new NotImplementedException();
        }

        public void SiustiPirmaDuomeni()
        {
            throw new NotImplementedException();
        }

        public string SukurtiDuomenuEilute(IDuomenys duomuo)
        {
            throw new NotImplementedException();
            Console.WriteLine("sukurti");
        }


    }
}
