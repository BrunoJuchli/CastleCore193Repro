using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test436
    {
        private readonly Mock<IClass436> aClass;

        public Test436()
        {
            this.aClass = new Mock<IClass436>();
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
