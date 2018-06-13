using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test41
    {
        private readonly Mock<IClass41> aClass;

        public Test41()
        {
            this.aClass = new Mock<IClass41>();
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
