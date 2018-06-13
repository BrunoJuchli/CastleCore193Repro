using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test213
    {
        private readonly Mock<IClass213> aClass;

        public Test213()
        {
            this.aClass = new Mock<IClass213>();
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
