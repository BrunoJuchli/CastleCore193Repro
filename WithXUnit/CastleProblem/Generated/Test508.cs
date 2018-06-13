using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test508
    {
        private readonly Mock<IClass508> aClass;

        public Test508()
        {
            this.aClass = new Mock<IClass508>();
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
