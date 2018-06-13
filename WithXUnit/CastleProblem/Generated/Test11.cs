using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test11
    {
        private readonly Mock<IClass11> aClass;

        public Test11()
        {
            this.aClass = new Mock<IClass11>();
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
