using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test643
    {
        private readonly Mock<IClass643> aClass;

        public Test643()
        {
            this.aClass = new Mock<IClass643>();
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
