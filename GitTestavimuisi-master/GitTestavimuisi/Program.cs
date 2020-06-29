using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestavimuisi
{
    class Duomenys : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set; }
        public DateTime DuomenuParuososLaikas { get; set; }
    }

    class Komunikacija : IKomunikacija
    {
        public string Msg { get; set; }
        public void PakartotiPaskutineZinute()
        {
            Console.WriteLine(Msg);
        }

        public void Siusti(string zinute)
        {
            Console.WriteLine(zinute);
        }

        public string SkaitytiDuomenis()
        {
            Console.WriteLine("Enter msg");
            Msg = Console.ReadLine();
            return Msg;

        }
    }

    class Duomenu_paruosimas : IDuomenu_paruosimas
    {
        public List<IDuomenys> Data { get; }

        public void PridetiDuomeni(IDuomenys duomuo)
        {
            Data.Add(duomuo);
        }

        public void SiustiDuomeni(int kelintas)
        {
            Console.WriteLine(Data[kelintas]);
        }

        public void SiustiPaskutinDuomeni()
        {
            Console.WriteLine(Data[Data.Count()]);
        }

        public void SiustiPirmaDuomeni()
        {
            Console.WriteLine(Data[0]);
        }

        public string SukurtiDuomenuEilute(IDuomenys duomuo)
        {
            var duomenys = duomuo;

            return duomenys.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
