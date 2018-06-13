using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test30
    {
        private readonly Mock<IClass30> aClass;

        public Test30()
        {
            this.aClass = new Mock<IClass30>();
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
