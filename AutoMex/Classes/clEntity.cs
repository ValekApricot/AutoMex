using AutoMex.DateBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMex.Classes
{
    internal class clEntity
    {
        public static SychevAvtoShouEntities Context { get; } = new SychevAvtoShouEntities();
        public static int IDChange = 0;
        public static bool Change = false;
        public static string LoginNow;
    }
}

