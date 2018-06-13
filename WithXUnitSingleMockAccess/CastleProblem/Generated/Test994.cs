using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test994
    {
        private readonly Mock<IClass994> aClass;

        public Test994()
        {
            this.aClass = new Mock<IClass994>();
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
