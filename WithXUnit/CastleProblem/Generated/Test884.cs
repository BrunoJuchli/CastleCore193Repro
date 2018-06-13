using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test884
    {
        private readonly Mock<IClass884> aClass;

        public Test884()
        {
            this.aClass = new Mock<IClass884>();
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
