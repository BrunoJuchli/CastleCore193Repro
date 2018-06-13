using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test708
    {
        private readonly Mock<IClass708> aClass;

        public Test708()
        {
            this.aClass = new Mock<IClass708>();
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
