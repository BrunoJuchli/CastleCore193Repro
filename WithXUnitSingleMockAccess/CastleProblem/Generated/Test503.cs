using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test503
    {
        private readonly Mock<IClass503> aClass;

        public Test503()
        {
            this.aClass = new Mock<IClass503>();
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
