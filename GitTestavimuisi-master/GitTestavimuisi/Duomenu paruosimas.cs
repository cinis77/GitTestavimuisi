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

    interface IDuomenu_paruosimas
    {
        List<IDuomenys> Data { get; }

        string SukurtiDuomenuEilute(IDuomenys duomuo);

        void PridetiDuomeni(IDuomenys duomuo);

        void SiustiPirmaDuomeni();

        void SiustiDuomeni(int kelintas);

        void SiustiPaskutinDuomeni();
    }
    class Duomenu_paruosimas:IDuomenu_paruosimas
    {
    public List<IDuomenys> Data{get;}
    
    public void PridetiDuomeni(IDuomenys duomuo)
    {
    
    }
    public void SiustiDuomeni(int kelintas)
    {
    }
    public void SiustiPaskutiniDuomeni()
    {
    }
    public void SiustiPirmaDuomeni()
    {
    }
    public string SukurtiDuomenuEilute(IDuomenys duomuo)
    {
    string a="shsjfjsjfs";
    return a;
    }
    }
}
