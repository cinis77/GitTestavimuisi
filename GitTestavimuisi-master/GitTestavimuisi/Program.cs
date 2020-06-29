
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
        public void PakartotiPaskutineZinute()
        {
            
        }

        public void Siusti(string zinute)
        {
         
        }

        public string SkaitytiDuomenis()
        {

            return "duomenys";

        }
    }

    class Duomenu_paruosimas : IDuomenu_paruosimas
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
            var duomenys = duomuo;

            return duomenys.ToString();
        }
    }

    class DuomenuParuosimas_RK : IDuomenu_paruosimas
    {
        public List<IDuomenys> Data  = new List<IDuomenys>();

        List<IDuomenys> IDuomenu_paruosimas.Data => throw new NotImplementedException();


        public void PridetiDuomeni(IDuomenys duomuo)
        {
            Data.Add(duomuo);
        }

        public void SiustiDuomeni(int kelintas)
        {
            Console.WriteLine(kelintas);
        }

        public void SiustiPaskutinDuomeni()
        {
            Console.WriteLine("Paskutiniai duomenys: {0}", Data.Last());
        }

        public void SiustiPirmaDuomeni()
        {
            Console.WriteLine("Pirmas duomuo: {0}", Data.First()); ;
        }

        public string SukurtiDuomenuEilute(IDuomenys duomuo)
        {
            return duomuo.Zinute;
        }
    }

    class Komunikacija_RK : IKomunikacija
    {
        public void PakartotiPaskutineZinute()
        {
            string zinute = "Paskutine zinute";
            Siusti(zinute);
        }

        public void Siusti(string zinute)
        {
            Console.WriteLine(zinute);
        }

        public string SkaitytiDuomenis()
        {
            return Console.ReadLine();
        }
    }

    class DuomenuKlase : IDuomenys
    {
        public int Id { get; set;  }
        public string Zinute { get; set; }
        public DateTime DuomenuParuososLaikas { get; set; }

        public DuomenuKlase(int id)
        {
            Id = id;
            DuomenuParuososLaikas = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Duomenys : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set; }
        public DateTime DuomenuParuososLaikas { get; set; }
    }

    class Komunikacija : IKomunikacija
    {
        public string Message { get; set; }
        public void PakartotiPaskutineZinute()
        {
			Console.WriteLine(Message);
        }

        public void Siusti(string zinute)
        {
			Console.WriteLine(zinute); 
        }

        public string SkaitytiDuomenis()
        {
            Console.WriteLine("Entrer Message:");
            Message = Console.ReadLine();
            return Message;
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
            Console.WriteLine(Data[Data.Count() - 1]);
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


    class Duomenys : IDuomenys
    {
        public int Id { get; set; }
        public string Zinute { get; set; }
        public DateTime DuomenuParuososLaikas { get; set; }
    }

    class Komunikacija : IKomunikacija
    {

        public Komunikacija()
        {
            Console.WriteLine("Sveiki");
        }


        public string Msg { get; set; }

        public void PakartotiPaskutineZinute()
        {
            Console.WriteLine(Msg);
        }

        public void Siusti(string zinute)
        {

            LastMsg = zinute;
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

   
}


