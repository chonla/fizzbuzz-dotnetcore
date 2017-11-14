using System;
using FizzBuzz;
using Xunit;

namespace FizzBuzz.Tests {
    public class FizzBuzzTest {
        private FizzBuzz fizzbuzz;

        public FizzBuzzTest () {
            this.fizzbuzz = new FizzBuzz ();
        }

        [Theory]
        [InlineData (1)]
        [InlineData (2)]
        public void TestShouldBeTheSameNumberWhenGiveANumberNotDivisibleBy3And5 (int v) {
            var result = fizzbuzz.Say (v);
            Assert.Equal (v.ToString (), result);
        }

        [Theory]
        [InlineData (3)]
        [InlineData (6)]
        public void TestShouldBeFizzWhenGiveValueDivisibleBy3 (int v) {
            var result = this.fizzbuzz.Say (v);
            Assert.Equal ("Fizz", result);
        }

        [Theory]
        [InlineData (5)]
        [InlineData (10)]
        public void TestShouldBeBuzzWhenGiveValueDivisibleBy5 (int v) {
            var result = this.fizzbuzz.Say (v);
            Assert.Equal ("Buzz", result);
        }

        [Theory]
        [InlineData (15)]
        [InlineData (30)]
        public void TestShouldBeFizzBuzzWhenGiveValueDivisibleBy15 (int v) {
            var result = this.fizzbuzz.Say (v);
            Assert.Equal ("FizzBuzz", result);
        }
    }
}