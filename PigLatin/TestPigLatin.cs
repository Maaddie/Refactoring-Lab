using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
   public class TestPigLatin
    {
        //public static string GetInput(string prompt)
        //{
        //    Console.WriteLine(prompt);
        //    string input = Console.ReadLine().ToLower().Trim();
        //    return input;
        //}

        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "onmytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]

        public void TestPig(string input, string expected)
        {
            //Arrange
            PigLatin pig = new PigLatin();

            //act
            string actual = pig.ToPigLatin(input);

            //assert
            Assert.Equal(expected, actual);
        }


    }
}
