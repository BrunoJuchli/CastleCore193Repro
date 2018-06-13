using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test154
    {
        private readonly Mock<IClass154> aClass;

        public Test154()
        {
            this.aClass = new Mock<IClass154>();
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
