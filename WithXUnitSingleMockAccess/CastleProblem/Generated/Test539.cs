using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test539
    {
        private readonly Mock<IClass539> aClass;

        public Test539()
        {
            this.aClass = new Mock<IClass539>();
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
