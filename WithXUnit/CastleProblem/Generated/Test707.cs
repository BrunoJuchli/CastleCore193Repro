using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test707
    {
        private readonly Mock<IClass707> aClass;

        public Test707()
        {
            this.aClass = new Mock<IClass707>();
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
