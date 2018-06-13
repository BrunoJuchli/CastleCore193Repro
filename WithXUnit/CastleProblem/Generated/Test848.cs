using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test848
    {
        private readonly Mock<IClass848> aClass;

        public Test848()
        {
            this.aClass = new Mock<IClass848>();
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
