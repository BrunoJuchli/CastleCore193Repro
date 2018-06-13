using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test444
    {
        private readonly Mock<IClass444> aClass;

        public Test444()
        {
            this.aClass = new Mock<IClass444>();
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
