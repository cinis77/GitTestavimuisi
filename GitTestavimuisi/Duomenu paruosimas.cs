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

    interface IKomunikacija
    {
        void Siusti(string zinute);
        string SkaitytiDuomenis();
        void PakartotiPaskutineZinute();
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
}    
