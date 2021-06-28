using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftHelper.src.support
{
    static class Support
    {
        public static string Indent(int amt)
        {
            return new string('\t', amt);
        }
    }
}
