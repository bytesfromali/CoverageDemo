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
    }
}