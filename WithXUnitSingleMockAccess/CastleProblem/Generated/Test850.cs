using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test850
    {
        private readonly Mock<IClass850> aClass;

        public Test850()
        {
            this.aClass = new Mock<IClass850>();
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
