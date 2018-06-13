using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test586
    {
        private readonly Mock<IClass586> aClass;

        public Test586()
        {
            this.aClass = new Mock<IClass586>();
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
