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
        }
    }
}
