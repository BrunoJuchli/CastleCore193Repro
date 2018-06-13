using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test324
    {
        private readonly Mock<IClass324> aClass;

        public Test324()
        {
            this.aClass = new Mock<IClass324>();
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
