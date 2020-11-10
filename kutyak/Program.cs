using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kutyak
{
    class Program
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<Kutyafajta> kutyafajtak = new List<Kutyafajta>();
        static List<Kutya> kutyalista = new List<Kutya>();
        static void KutyaNevekBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(Convert.ToInt32(adat[0]), adat[1]));
            }

            be.Close();
        }
        static void Harmadik()
        {
            Console.WriteLine($"Harmadik feladat: Kutyanevek száma: {kutyaNevek.Count}");
        }
        static void KutyaFajtaBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaFajtak.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');
                kutyafajtak.Add(new Kutyafajta(Convert.ToInt32(adat[0]),adat[1],adat[2]));
            }       
            be.Close();
        }
        static void KutyaBeolvasas()
        {
            StreamReader be = new StreamReader("Kutyak.csv");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');
                kutyalista.Add(new Kutya(int.Parse(adat[0]), int.Parse(adat[1]), int.Parse(adat[2]), int.Parse(adat[3]), adat[4]));
            }
            be.Close();
        }
        public static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            Harmadik();
            KutyaFajtaBeolvasas();
            KutyaBeolvasas();
            Console.ReadKey();
        }
    }
}
