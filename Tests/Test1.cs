using NUnit.Framework;
using System.Text;

namespace Saber.Tests
{
   [TestFixture]
   
   public class ProgramTests
   {
       [TestCase(42, "00000000000000000000000000101010")]
        [TestCase(10, "00000000000000000000000000001010")]
        [TestCase(0,  "00000000000000000000000000000000")]
        [TestCase(-5, "11111111111111111111111111111011")]
        [TestCase(-10, "11111111111111111111111111110110")]
        public void TestToBinary(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Program.IntToBinaryStringFormat(input));
        }

        [TestCase("AAA BBB AAA", "A B A")]
        [TestCase("CCCCCCCCC", "C")]
        [TestCase("CCCSCC", "CSC")]
        [TestCase("A  B  A  A B", "A B A A B")]
        [TestCase("SPOON", "SPON")]
        public void TestRemoveDups(string input, string expectedResult)
        {
            var data = new StringBuilder(input);
            Program.RemoveDups(data);
            Assert.AreEqual(expectedResult, data.ToString());
        }
    }
}