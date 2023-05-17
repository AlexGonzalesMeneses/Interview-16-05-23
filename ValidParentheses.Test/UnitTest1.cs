namespace ValidParentheses.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var solution = new Solution();
            Assert.True(solution.IsValid("()"));
        }

        [Fact]
        public void Test2()
        {
            var solution = new Solution();
            Assert.True(solution.IsValid("()[]{}"));
        }

        [Fact]
        public void Test3()
        {
            var solution = new Solution();
            Assert.False(solution.IsValid("(]"));
        }
    }
}