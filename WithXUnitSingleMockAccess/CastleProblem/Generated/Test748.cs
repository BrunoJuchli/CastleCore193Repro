using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test748
    {
        private readonly Mock<IClass748> aClass;

        public Test748()
        {
            this.aClass = new Mock<IClass748>();
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
