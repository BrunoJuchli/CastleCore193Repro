using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test659
    {
        private readonly Mock<IClass659> aClass;

        public Test659()
        {
            this.aClass = new Mock<IClass659>();
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
