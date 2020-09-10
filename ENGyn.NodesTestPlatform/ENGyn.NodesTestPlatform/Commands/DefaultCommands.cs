﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGyn.NodesTestPlatform.Commands
{
    /// <summary>
    /// This class contains all the methods that correspond to each command that can be executed from the application.
    /// </summary>
    public static class DefaultCommands
    {
        public static string Test()
        {
            return string.Format("Executed method without arguments");
        }

        public static string GetDate(DateTime date)
        {
            return string.Format("Date and time is: {0}", date);
        }
    }
}
