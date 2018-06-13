using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test426
    {
        private readonly Mock<IClass426> aClass;

        public Test426()
        {
            this.aClass = new Mock<IClass426>();
        }

        [Theory]
        [InlineData(true)]
        public void DoSomething(bool value)
        {
            this.aClass.Setup(x => x.DoSomething()).Returns(value);

            Assert.Equal(this.aClass.Object.DoSomething(), value);
        }
    }
}
