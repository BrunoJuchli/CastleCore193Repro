using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test887
    {
        private readonly Mock<IClass887> aClass;

        public Test887()
        {
            this.aClass = new Mock<IClass887>();
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
