using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko {
    class Obbiettivo {
        public byte Id { get; set; }//  0->numero territori 1->colore nemico 2->continenti
        public int NumeroTerritori { get; set; }
        public List<Continente> ContinentiObligaatori { get; }
        public bool ContinenteAScelta { get; }
        public Colore Nemico { get; set; }

        public Obbiettivo(int numeroTerritori) {
            this.NumeroTerritori = numeroTerritori;
            this.Id = 0;
        }

        public Obbiettivo(Colore colore) {
            this.Nemico = colore;
            this.Id = 1;
        }

        public Obbiettivo(List<Continente> listaContinenti, bool continenteAScelta) {
            this.ContinentiObligaatori = listaContinenti;
            this.ContinenteAScelta = continenteAScelta;
            this.Id = 2;
        }

    }
}
