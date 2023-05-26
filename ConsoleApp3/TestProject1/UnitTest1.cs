using Xunit;
using ConsoleApp3;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int answer = 9969;
            int num = OnePlusOne.Plus(9669);
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test2()
        {
            int answer = 9999;
            int num = OnePlusOne.Plus(9996);
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test3()
        {
            int answer = 9999;
            int num = OnePlusOne.Plus(9999);
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test4()
        {
            string answer = "dcbaefd";
            string num = ReversePrefixOfWord.Reverse("abcdefd", 'd');
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test5()
        {
            string answer = "zxyxxe";
            string num = ReversePrefixOfWord.Reverse("xyxzxe", 'z');
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test6()
        {
            string answer = "abcd";
            string num = ReversePrefixOfWord.Reverse("abcd", 'z');
            Assert.Equal(answer, num);
        }
        [Fact]
        public void Test7()
        {
            int[] answer = { 1, 2, 4 };
            int[] input = { 1, 2, 3 };
            int[] output = PlusOne.Plus(input);
            Assert.Equal(answer, output);
        }
        [Fact]
        public void Test8()
        {
            int[] answer = { 4, 3, 2, 2 };
            int[] input = { 4, 3, 2, 1 };
            int[] output = PlusOne.Plus(input);
            Assert.Equal(answer, output);
        }
        
        [Fact]
        public void Test10()
        {
            int answer = 2;
            int input = 4;
            double output = Sqrt_x_.Sqrt(input);
            Assert.Equal(answer, output);
        }
        [Fact]
        public void Test11()
        {
            bool answer = false;
            string input = "0P";
            bool output = ValidPalindrome.isPlindrome(input);
            Assert.Equal(answer, output);
        }
        [Fact]
        public void Test12()
        {
            bool answer = true;
            int input = 1;
            bool output = ReverseBits.reverseBits(input);
            Assert.Equal(answer, output);
        }
        [Fact]
        public void Test13()
        {
            bool answer = true;
            int input = 16;
            bool output = ReverseBits.reverseBits(input);
            Assert.Equal(answer, output);
        }
       
    }

    }
