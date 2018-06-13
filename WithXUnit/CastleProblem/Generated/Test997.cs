using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test997
    {
        private readonly Mock<IClass997> aClass;

        public Test997()
        {
            this.aClass = new Mock<IClass997>();
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
