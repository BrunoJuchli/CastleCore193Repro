using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test308
    {
        private readonly Mock<IClass308> aClass;

        public Test308()
        {
            this.aClass = new Mock<IClass308>();
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
