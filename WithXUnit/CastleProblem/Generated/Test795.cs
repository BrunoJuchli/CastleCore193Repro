using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test795
    {
        private readonly Mock<IClass795> aClass;

        public Test795()
        {
            this.aClass = new Mock<IClass795>();
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
