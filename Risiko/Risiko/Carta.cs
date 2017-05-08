namespace Risiko {
    public class Carta {
        public Bonus Bonus {get; set; }
        public int Id { get; set; }

        public Carta(Bonus bonus, int id) {
            this.Bonus = bonus;
            this.Id = id;
        }

    }
}