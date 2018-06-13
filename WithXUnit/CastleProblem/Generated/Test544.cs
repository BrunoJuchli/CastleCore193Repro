using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test544
    {
        private readonly Mock<IClass544> aClass;

        public Test544()
        {
            this.aClass = new Mock<IClass544>();
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
