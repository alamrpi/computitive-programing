using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputitivePrograming.Leetcode.Easy
{
    /// <summary>
    /// You are given a string s of even length. Split this string into two halves of equal lengths, and let a be the first half and b be the second half.
    /// Two strings are alike if they have the same number of vowels('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'). Notice that s contains uppercase and lowercase letters.
    /// Return true if a and b are alike.Otherwise, return false.
    /// </summary>
    public class StringHalfesALike1704
    {
        public bool Solution(string s)
        {
            int firstHalfCount = 0, secondHalfCount = 0;
            int halfLenghtString = s.Length / 2;
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };

            char[] firstHalfArray = s.Substring(0, halfLenghtString).ToCharArray();
            char[] secondHalfArray = s.Substring(halfLenghtString, halfLenghtString).ToCharArray();

            for (int i = 0; i < halfLenghtString; i++)
            {
                if (vowels.Any(v => v == firstHalfArray[i].ToString().ToLower()))
                    firstHalfCount++;

                if (vowels.Any(v => v == secondHalfArray[i].ToString().ToLower()))
                    secondHalfCount++;
            }
            return firstHalfCount == secondHalfCount;
        }
    }

    [TestFixture]
    public class StringHalfesTest
    {
        [Test]
        public void TestCase1()
        {
            var strHalfAlike = new StringHalfesALike1704();

            Assert.IsTrue(strHalfAlike.Solution("book"));
        }

        [Test]
        public void TestCase2()
        {
            var strHalfAlike = new StringHalfesALike1704();
            Assert.IsTrue(strHalfAlike.Solution("textbook"));
        }
    }
}
