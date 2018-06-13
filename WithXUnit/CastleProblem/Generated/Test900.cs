using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test900
    {
        private readonly Mock<IClass900> aClass;

        public Test900()
        {
            this.aClass = new Mock<IClass900>();
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
