using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test366
    {
        private readonly Mock<IClass366> aClass;

        public Test366()
        {
            this.aClass = new Mock<IClass366>();
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
