using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test335
    {
        private readonly Mock<IClass335> aClass;

        public Test335()
        {
            this.aClass = new Mock<IClass335>();
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
