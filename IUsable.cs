using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHalf
{
    interface IUsable
    {
        string SuccessMessage { get; }
        string FailureMessage { get; }
        int UsesLeft { get; set; }
        float UseChance { get; set; }   // range of 0.0 to 1.0
        bool Used();                    // if successfully used, return true
    }
}
