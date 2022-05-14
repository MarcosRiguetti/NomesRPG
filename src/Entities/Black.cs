namespace dotnet__poo.src.Entities
{
    public class Black : Hero
    {
        public Black(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou Magia Negra";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Lançou Magia Negra super efetiva com bonus de ataque de " + Bonus;
            }
            else {
                return this.Name + " Lançou uma Magia Negra com força fraca com bonus de " + Bonus;
            }
        }
    }
}