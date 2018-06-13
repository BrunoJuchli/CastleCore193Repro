using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test929
    {
        private readonly Mock<IClass929> aClass;

        public Test929()
        {
            this.aClass = new Mock<IClass929>();
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
