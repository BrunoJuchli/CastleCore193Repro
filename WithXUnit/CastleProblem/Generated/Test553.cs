using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test553
    {
        private readonly Mock<IClass553> aClass;

        public Test553()
        {
            this.aClass = new Mock<IClass553>();
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
