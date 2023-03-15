using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsFireInheritance
{
    internal class Sword : Weapon
    {
        public Sword(string title, string description) : base(title, description)
        {
        }

        public string FireVoice()
        {
            return "Хыщ хыщ";
        }

        public string WeaponDamage()
        {
            return "20HP";
        }
    }
}
