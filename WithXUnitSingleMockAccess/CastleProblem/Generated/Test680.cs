using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test680
    {
        private readonly Mock<IClass680> aClass;

        public Test680()
        {
            this.aClass = new Mock<IClass680>();
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
