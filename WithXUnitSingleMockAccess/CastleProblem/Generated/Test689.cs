using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test689
    {
        private readonly Mock<IClass689> aClass;

        public Test689()
        {
            this.aClass = new Mock<IClass689>();
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
