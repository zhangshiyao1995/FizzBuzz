using FizzBuzz.Library;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService fizzBuzz;

        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzzService();
        }

        [Fact]

        public void ShouldReturnNumber()
        {
            Assert.Equal("1", fizzBuzz.Print(1));
            Assert.Equal("2", fizzBuzz.Print(2));
        }
       [Fact]
       public void ShouldReturnFizz()
        {
            Assert.Equal("Fizz", fizzBuzz.Print(3));
        }
        [Fact]
       public void ShouldReturnBuzz()
        {
            Assert.Equal("Buzz", fizzBuzz.Print(5));
        }
        [Fact]
       public void ShouldReturnFizzBuzz()
        {
            Assert.Equal("FizzBuzz", fizzBuzz.Print(15));
        }
    }
}