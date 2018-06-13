using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test551
    {
        private readonly Mock<IClass551> aClass;

        public Test551()
        {
            this.aClass = new Mock<IClass551>();
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
