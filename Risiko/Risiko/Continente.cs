namespace Risiko {
    public class Continente {
        public string NomeC {get; set; }
        public int[] StatiContinente {get; set; }
        public int nTruppeBonus {get; set; }
        public int Id { get; set; }

        public Continente(string nome, int id, int numStati, int nTruppeBonus) {
            this.NomeC = nome;
            this.nTruppeBonus = nTruppeBonus;
            this.StatiContinente = new int[numStati];
            this.Id = id
        }
   
    } 
}
