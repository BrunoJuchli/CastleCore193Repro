using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test809
    {
        private readonly Mock<IClass809> aClass;

        public Test809()
        {
            this.aClass = new Mock<IClass809>();
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
