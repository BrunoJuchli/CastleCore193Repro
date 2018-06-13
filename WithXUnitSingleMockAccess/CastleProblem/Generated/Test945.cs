using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test945
    {
        private readonly Mock<IClass945> aClass;

        public Test945()
        {
            this.aClass = new Mock<IClass945>();
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
