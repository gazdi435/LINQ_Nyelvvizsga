using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Unicode;

namespace Nyelvvizsga
{
    internal class Program
    {
        public static List<Vizsga> lista = new List<Vizsga>();
        static void Main(string[] args)
        {
            Beolvasas("sikeres.csv", true);
            Beolvasas("C:\\Users\\Zsolesz\\source\\repos\\Nyelvvizsga\\Nyelvvizsga\\bin\\Debug\\net6.0\\sikertelen.csv", false);

            MasodikFeladat();
            HarmadikEsNegyedikFeladat();

        }

        private static void HarmadikEsNegyedikFeladat()
        {
            Console.Write("Kérem adjon meg egy évet: ");

            int megadottEv;

            do
            {
                megadottEv = Convert.ToInt32(Console.ReadLine());

            } while (megadottEv < 2008 && megadottEv > 2018);

            lista.Where(x => x.Sikeres == false).ToList().OrderBy(x => x.Osszesen/(x.Osszesen + (Convert.ToInt32(lista.Where(y => y.Nyelv == x.Nyelv && y.Sikeres == false).First().Osszesen)))*100).ToList().ForEach(x => { Console.WriteLine($"4-es feladat: {Convert.ToInt32(x.Osszesen) / (x.Osszesen + Convert.ToInt32(lista.Where(y => y.Nyelv == x.Nyelv && y.Sikeres == false).First().Osszesen)) * 100}"); });


        }

        private static void MasodikFeladat()
        {
            lista.OrderBy(x => x.Osszesen + lista.Where(y => y.Nyelv == x.Nyelv && y.Sikeres != x.Sikeres).First().Osszesen).Take(3).ToList().ForEach(x => { Console.WriteLine(x.Nyelv); });
        }

        private static void Beolvasas(string eleresiUt, bool sikerese)
        {

            File.ReadAllLines(eleresiUt, Encoding.UTF8).Skip(1).ToList().ForEach(x => { lista.Add(new Vizsga(x, sikerese)); });

        }
    }
}