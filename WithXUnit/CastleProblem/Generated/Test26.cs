using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test26
    {
        private readonly Mock<IClass26> aClass;

        public Test26()
        {
            this.aClass = new Mock<IClass26>();
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
