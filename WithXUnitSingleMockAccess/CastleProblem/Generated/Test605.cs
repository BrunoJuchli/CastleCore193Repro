using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test605
    {
        private readonly Mock<IClass605> aClass;

        public Test605()
        {
            this.aClass = new Mock<IClass605>();
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
