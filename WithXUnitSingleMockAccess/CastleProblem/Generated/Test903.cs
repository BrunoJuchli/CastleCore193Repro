using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test903
    {
        private readonly Mock<IClass903> aClass;

        public Test903()
        {
            this.aClass = new Mock<IClass903>();
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
