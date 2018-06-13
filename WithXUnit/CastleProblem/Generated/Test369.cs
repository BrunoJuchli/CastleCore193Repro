using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test369
    {
        private readonly Mock<IClass369> aClass;

        public Test369()
        {
            this.aClass = new Mock<IClass369>();
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
