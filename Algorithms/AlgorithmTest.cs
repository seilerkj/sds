using Xunit;

namespace DeveloperSample.Algorithms
{
    public class AlgorithmTest
    {
        [Fact()]
        public void CanGetFactorial()
        {
            Assert.Equal(24, Algorithms.GetFactorial(4));
            Assert.Equal(720, Algorithms.GetFactorial(6));
            
            Assert.Equal(6, Algorithms.GetFactorial(3));
            Assert.Equal(1, Algorithms.GetFactorial(1));
           
         
            

        }

        [Fact()]
        public void CanFormatSeparators()
        {
            Assert.Equal("a, b and c", Algorithms.FormatSeparators("a", "b", "c"));

            Assert.Equal("a, b, c and d", Algorithms.FormatSeparators("a", "b", "c","d"));


        }
    }
}