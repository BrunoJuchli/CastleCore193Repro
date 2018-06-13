using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test479
    {
        private readonly Mock<IClass479> aClass;

        public Test479()
        {
            this.aClass = new Mock<IClass479>();
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
