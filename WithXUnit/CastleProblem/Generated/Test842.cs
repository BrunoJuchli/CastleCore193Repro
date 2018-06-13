using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test842
    {
        private readonly Mock<IClass842> aClass;

        public Test842()
        {
            this.aClass = new Mock<IClass842>();
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
