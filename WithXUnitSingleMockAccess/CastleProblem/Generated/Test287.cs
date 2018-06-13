using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test287
    {
        private readonly Mock<IClass287> aClass;

        public Test287()
        {
            this.aClass = new Mock<IClass287>();
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
