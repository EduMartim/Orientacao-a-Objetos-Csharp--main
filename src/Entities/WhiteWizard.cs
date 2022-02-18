using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_de_RPG_usando_OO.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + "," + " " + "lançou magia";
        }
        public string Attack(int Bonus)
        {

            if (Bonus > 6)
            {
                return this.Name + " Lançou SUPERMagia com bonus de " + Bonus;

            }
            else
            {
                return this.Name + " Lançou Magia fraca com bonus de " + Bonus;
            }
        }
    }
}