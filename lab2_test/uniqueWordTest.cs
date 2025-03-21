using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_classlib;

namespace lab2_test
{
    public class uniqueWordTest
    {
        [Theory]
        [InlineData("abcd", true)]
        public void IsWordUnique_TestCases(string word, bool expected)
        {
            var result = uniqueWord.IsWordUnique (word);
            Assert.Equal(expected, result);
        }
    }
}
