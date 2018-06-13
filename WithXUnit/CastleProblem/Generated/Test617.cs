using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test617
    {
        private readonly Mock<IClass617> aClass;

        public Test617()
        {
            this.aClass = new Mock<IClass617>();
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
