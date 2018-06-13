using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test512
    {
        private readonly Mock<IClass512> aClass;

        public Test512()
        {
            this.aClass = new Mock<IClass512>();
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
