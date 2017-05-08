using System;
using System.Collections.Generic;

namespace Risiko {
    public class Stato : Carta{
        public string Nome {get; set;}
        public List<int> Confini {get; set; }
        
        public Stato(string nome, int id, Bonus bonus, List<int> confini) : base(bonus, id){
            this.Nome = nome;
            this.Confini = confini;
        }

        


    }
}
