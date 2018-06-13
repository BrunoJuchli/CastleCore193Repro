using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test520
    {
        private readonly Mock<IClass520> aClass;

        public Test520()
        {
            this.aClass = new Mock<IClass520>();
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
