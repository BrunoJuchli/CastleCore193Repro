using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test558
    {
        private readonly Mock<IClass558> aClass;

        public Test558()
        {
            this.aClass = new Mock<IClass558>();
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
