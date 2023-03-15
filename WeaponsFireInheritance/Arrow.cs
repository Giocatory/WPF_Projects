using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsFireInheritance
{
    internal class Arrow : Weapon
    {
        public Arrow(string title, string description) : base(title, description)
        {
        }

        public string FireVoice()
        {
            return "пиу пиу";
        }

        public string WeaponDamage()
        {
            return "30HP";
        }
    }
}
