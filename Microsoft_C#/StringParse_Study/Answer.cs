using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParse_Study
{
    public class Answer
    {
        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public static bool CountTheType(object Arg, string TypeToCount)
        {
            // Your code goes here. Return true if the type of the Arg is the same
            // as what the TypeToCount parameter says to count.
            var res = Arg.GetType();
            var res2 = TypeToCount.GetType();

            if (res == res2)
            {
                return true;
            }

            return false;
        }
    }
}
