namespace CoverageDemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void MainSumTest()
        {
            var num1 = 12;
            var num2 = 13;
            var sum = 25;
            var obj = new Calculator(num1, num2);

            var result = obj.Sum();

            Assert.Equal(sum, result);
        }

        [Fact]
        public void MainMinusTest()
        {
            var num1 = 12;
            var num2 = 13;
            var substraction = -1;
            var obj = new Calculator(num1, num2);

            var result = obj.Minus();

            Assert.Equal(substraction, result);
        }

        [Fact]
        public void MainDivisionTest()
        {
            var num1 = 12;
            var num2 = 3;
            var substraction = 4;
            var obj = new Calculator(num1, num2);

            var result = obj.Division();

            Assert.Equal(substraction, result);
        }

        [Fact]
        public void MainDivideByZeroTest()
        {
            var num1 = 12;
            var num2 = 0;
            var obj = new Calculator(num1, num2);

            Assert.Throws<DivideByZeroException>(() => obj.Division());
        }
    }
}