using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineInZoo
{
    class VendingMachine
    {
        public virtual string Item { get; set; }

        protected virtual bool CheckAmount(decimal money) => false;

        public string Dispense(decimal money)
        {
            if (CheckAmount(money)) return Item;
            else return "Пожалуйста, введите правильную сумму";
        }
    }
}