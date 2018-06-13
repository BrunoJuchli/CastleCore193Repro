using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test500
    {
        private readonly Mock<IClass500> aClass;

        public Test500()
        {
            this.aClass = new Mock<IClass500>();
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
