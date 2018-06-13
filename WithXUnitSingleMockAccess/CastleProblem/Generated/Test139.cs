using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test139
    {
        private readonly Mock<IClass139> aClass;

        public Test139()
        {
            this.aClass = new Mock<IClass139>();
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
