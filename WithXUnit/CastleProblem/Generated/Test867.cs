using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test867
    {
        private readonly Mock<IClass867> aClass;

        public Test867()
        {
            this.aClass = new Mock<IClass867>();
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
