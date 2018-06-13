using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test35
    {
        private readonly Mock<IClass35> aClass;

        public Test35()
        {
            this.aClass = new Mock<IClass35>();
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
