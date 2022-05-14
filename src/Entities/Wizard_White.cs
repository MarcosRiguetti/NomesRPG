namespace dotnet__poo.src.Entities
{
    public class Wizard_White : Hero
    {
        public Wizard_White(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de ataque de " + Bonus;
            }
            else {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}