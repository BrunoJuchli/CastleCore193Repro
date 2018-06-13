using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test905
    {
        private readonly Mock<IClass905> aClass;

        public Test905()
        {
            this.aClass = new Mock<IClass905>();
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
