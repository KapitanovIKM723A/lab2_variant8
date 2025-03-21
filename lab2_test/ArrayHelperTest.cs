using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_classlib;

namespace lab2_test
{
    public class ArrayHelperTest{
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })] 
        [InlineData(new[] { "a", "b", "c" }, new[] { "c", "b", "a" })]
        [InlineData(new[] { true, false }, new[] { false, true })]
        [InlineData(new int[] { }, new int[] { })]          
        public void ReverseArray_TestCases<T>(T[] input, T[] expected)
        {
            var result = ArrayHelper.ReverseArray(input);
            Assert.Equal(expected, result);
            Assert.Equal(input, input);
        } 
    }
}