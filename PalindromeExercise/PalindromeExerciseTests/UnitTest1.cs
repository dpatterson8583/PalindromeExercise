using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("saippuakivikauppias",true)]
        [InlineData("racecar", true)]
        [InlineData("Able was I ere I saw elbA", true)]
        [InlineData("Bazinga", false)]

        public void IsAPalindromeTest(string pal, bool expected)
        {
            //Arrange
            WordSmith ispal = new WordSmith();

            //Act
            bool actual = ispal.IsAPalindrome(pal);

            //Assert
            Assert.Equal(expected, actual);

           
        }
    }
}
