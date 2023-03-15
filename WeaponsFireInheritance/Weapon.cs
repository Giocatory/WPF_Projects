using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsFireInheritance
{
    abstract class Weapon : IWeaponEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Weapon(string title, string description)
        {
            Title = title;
            Description = description;
        }

        string IWeaponEvent.FireVoice() => "";

        string IWeaponEvent.WeaponDamage() => "";
    }
}
