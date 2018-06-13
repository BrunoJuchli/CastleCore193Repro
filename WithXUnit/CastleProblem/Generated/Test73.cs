using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test73
    {
        private readonly Mock<IClass73> aClass;

        public Test73()
        {
            this.aClass = new Mock<IClass73>();
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
