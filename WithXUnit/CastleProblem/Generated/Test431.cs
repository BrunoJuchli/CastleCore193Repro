using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test431
    {
        private readonly Mock<IClass431> aClass;

        public Test431()
        {
            this.aClass = new Mock<IClass431>();
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
