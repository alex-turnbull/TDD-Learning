using FizzBuzzApp;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Test_FizzBuzz_ResultShouldBe1()
        {
            FizzBuzzApp app = new FizzBuzzApp();

            var result = app.CalculateFizzBuzz(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void Test_FizzBuzz_ResultShouldBeFizz()
        {
            FizzBuzzApp app = new FizzBuzzApp();

            var result = app.CalculateFizzBuzz(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Test_FizzBuzz_ResultShouldBeBuzz()
        {
            FizzBuzzApp app = new FizzBuzzApp();

            var result = app.CalculateFizzBuzz(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Test_FizzBuzz_ResultShouldBeFizzBuzz()
        {
            FizzBuzzApp app = new FizzBuzzApp();

            var result = app.CalculateFizzBuzz(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Test_FizzBuzz_CorrectResultForString()
        {
            FizzBuzzApp app = new FizzBuzzApp();

            var result = app.MassCalculateFizzBuzz(new int[] {1,2,3,4,5,10,15,30,31,32});

            //            1,2,  3, 4,  5,   10,    15,     30,   31,32
            Assert.Equal("1,2,Fizz,4,Buzz,Buzz,FizzBuzz,FizzBuzz,31,32", result);
        }
    }
}