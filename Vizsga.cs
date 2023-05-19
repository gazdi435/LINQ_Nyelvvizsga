using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvvizsga
{
    internal class Vizsga
    {
        string nyelv;
        bool sikeres;
        int y2009;
        int y2010;
        int y2011;
        int y2012;
        int y2013;
        int y2014;
        int y2015;
        int y2016;
        int y2017;
        int osszesen;


        public Vizsga(string sor, bool sikeres)
        {
            string[] cucc = sor.Split(';');
            this.nyelv = cucc[0];
            this.sikeres = sikeres;
            this.y2009 = Convert.ToInt32(cucc[1]);
            this.y2010 = Convert.ToInt32(cucc[2]);
            this.y2011 = Convert.ToInt32(cucc[3]);
            this.y2012 = Convert.ToInt32(cucc[4]);
            this.y2013 = Convert.ToInt32(cucc[5]);
            this.y2014 = Convert.ToInt32(cucc[6]);
            this.y2015 = Convert.ToInt32(cucc[7]);
            this.y2016 = Convert.ToInt32(cucc[8]);
            this.y2017 = Convert.ToInt32(cucc[9]);
            this.osszesen = this.y2009 + this.Y2010 + this.Y2011 + this.Y2012 + this.Y2013 + this.Y2014 + this.Y2015 + this.Y2016 + this.y2017;
        }

        public Vizsga(string nyelv, bool sikeres, int y2009, int y2010, int y2011, int y2012, int y2013, int y2014, int y2015, int y2016, int y2017)
        {
            this.nyelv = nyelv;
            this.sikeres = sikeres;
            this.y2009 = y2009;
            this.y2010 = y2010;
            this.y2011 = y2011;
            this.y2012 = y2012;
            this.y2013 = y2013;
            this.y2014 = y2014;
            this.y2015 = y2015;
            this.y2016 = y2016;
            this.y2017 = y2017;
            this.osszesen = this.y2009 + this.Y2010 + this.Y2011 + this.Y2012 + this.Y2013 + this.Y2014 + this.Y2015 + this.Y2016 + this.y2017;
        }

        public string Nyelv { get => nyelv; }
        public bool Sikeres { get => sikeres; }
        public int Y2009 { get => y2009; }
        public int Y2010 { get => y2010; }
        public int Y2011 { get => y2011; }
        public int Y2012 { get => y2012; }
        public int Y2013 { get => y2013; }
        public int Y2014 { get => y2014; }
        public int Y2015 { get => y2015; }
        public int Y2016 { get => y2016; }
        public int Y2017 { get => y2017; }
        public int Osszesen { get => osszesen; }
    }
}
