using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test683
    {
        private readonly Mock<IClass683> aClass;

        public Test683()
        {
            this.aClass = new Mock<IClass683>();
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
