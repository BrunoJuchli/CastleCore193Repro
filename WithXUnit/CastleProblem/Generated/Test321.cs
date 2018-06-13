using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test321
    {
        private readonly Mock<IClass321> aClass;

        public Test321()
        {
            this.aClass = new Mock<IClass321>();
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
