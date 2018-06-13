using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test908
    {
        private readonly Mock<IClass908> aClass;

        public Test908()
        {
            this.aClass = new Mock<IClass908>();
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
