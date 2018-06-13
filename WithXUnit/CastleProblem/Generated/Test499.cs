using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test499
    {
        private readonly Mock<IClass499> aClass;

        public Test499()
        {
            this.aClass = new Mock<IClass499>();
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
