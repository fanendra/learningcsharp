using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ActionAndFuncDelegates
    {
        public ActionAndFuncDelegates(Action<string, ConsoleColor, int> actionTarget, int noOf)
        {
            if (noOf < 5)
            {
                actionTarget("Action Message", ConsoleColor.DarkGreen, noOf);
            }
            else
            {
                actionTarget("Action Message", ConsoleColor.DarkRed, noOf);
            }
        }

                                

    }
}
