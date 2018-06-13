using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test484
    {
        private readonly Mock<IClass484> aClass;

        public Test484()
        {
            this.aClass = new Mock<IClass484>();
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
