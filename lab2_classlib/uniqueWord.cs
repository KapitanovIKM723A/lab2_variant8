using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_classlib
{
    public class uniqueWord
    {
        public static bool IsWordUnique(string word)
        {
            return word.Distinct().Count() == word.Length;
        }
    }
}
