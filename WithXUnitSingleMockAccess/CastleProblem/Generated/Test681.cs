using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test681
    {
        private readonly Mock<IClass681> aClass;

        public Test681()
        {
            this.aClass = new Mock<IClass681>();
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
