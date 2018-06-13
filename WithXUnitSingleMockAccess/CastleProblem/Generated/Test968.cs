using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test968
    {
        private readonly Mock<IClass968> aClass;

        public Test968()
        {
            this.aClass = new Mock<IClass968>();
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
