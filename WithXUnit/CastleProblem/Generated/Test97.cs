using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test97
    {
        private readonly Mock<IClass97> aClass;

        public Test97()
        {
            this.aClass = new Mock<IClass97>();
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
