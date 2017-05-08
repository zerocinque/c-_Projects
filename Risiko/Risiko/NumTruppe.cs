using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko {
    public static class NumTruppe {
        
        public static int numTroppeGioc(int nGiocatori) {
            switch (nGiocatori) {
                case 3: return 35;
                case 4: return 30;
                case 5: return 25;
                case 6: return 20;
                default: return 0;
            }
        }

    }
}
