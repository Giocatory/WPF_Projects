using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineInZoo
{
    class AnimalFeedVendingMachine : VendingMachine
    {
        public override string Item
        {
            get
            {
                return "горсть корма для животных";
            }
            set
            {
                base.Item = value;
            }
        }

        protected override bool CheckAmount(decimal money)
        {
            return money >= 1.25M;
        }
    }
}
