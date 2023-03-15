using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowReadPrivateFields
{
    internal class HasASecret
    {
        private readonly string secret = "secret phraze";
        private int lengthSecretPhraze = 5;
        public int HowManyVars { private get; set; } = 2;
    }
}