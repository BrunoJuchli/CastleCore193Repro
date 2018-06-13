using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test330
    {
        private readonly Mock<IClass330> aClass;

        public Test330()
        {
            this.aClass = new Mock<IClass330>();
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
