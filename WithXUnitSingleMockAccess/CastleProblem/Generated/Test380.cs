using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test380
    {
        private readonly Mock<IClass380> aClass;

        public Test380()
        {
            this.aClass = new Mock<IClass380>();
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
