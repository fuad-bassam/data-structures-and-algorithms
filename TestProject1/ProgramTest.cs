using System;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class ProgramTest
    {


        ///Class 13: stack-queue-brackets
        [Fact]

        public void Class13_test1()
        {
            String x = "[x]";

            Assert.True(Program.validateBrackets(x));
        }
        [Fact]
     
        public void Class13_test2()
        {

            String x = "[][]{}";

            Assert.True(Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test3()
        {

            String x = "{s]";

            Assert.True(!Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test4()
        {

            String x = "{[(z)]}";

            Assert.True(Program.validateBrackets(x));

        }
        /////////

    }
}