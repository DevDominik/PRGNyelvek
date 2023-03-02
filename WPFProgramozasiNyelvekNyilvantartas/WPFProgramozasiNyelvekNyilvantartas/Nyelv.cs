using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProgramozasiNyelvekNyilvantartas
{
    public enum nyelvcsaladok { moduláris, strukturált, funkcionális, objektumorientált };
    public class Nyelv
    {
        string nev;
        bool forditosE;
        nyelvcsaladok nyelvcsalad;
        int megjelenesEve;
        bool alacsonyszintuE;
        int nepszeruseg2022;
        
        public Nyelv
            (
                string nev,
                bool forditosE,
                nyelvcsaladok nyelvcsalad,
                int megjelenesEve,
                bool alacsonyszintuE,
                int nepszeruseg2022
            )
        {
            this.nev = nev;
            this.forditosE = forditosE;
            this.nyelvcsalad = nyelvcsalad;
            this.megjelenesEve = megjelenesEve;
            this.alacsonyszintuE = alacsonyszintuE;
            this.nepszeruseg2022 = nepszeruseg2022;
        }
        public string Nev { get => nev; }
        public bool ForditosE { get => forditosE; }
        public nyelvcsaladok Nyelvcsalad { get => nyelvcsalad; }
        public int MegjelenesEve { get => megjelenesEve; }
        public bool AlacsonyszintuE { get => alacsonyszintuE; }
        public int Nepszeruseg2022 { get => nepszeruseg2022; }
        public bool NepszeruE { get => this.nepszeruseg2022 >= 3; }
    }
}
