using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test412
    {
        private readonly Mock<IClass412> aClass;

        public Test412()
        {
            this.aClass = new Mock<IClass412>();
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
