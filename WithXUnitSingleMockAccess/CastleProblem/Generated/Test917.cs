using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test917
    {
        private readonly Mock<IClass917> aClass;

        public Test917()
        {
            this.aClass = new Mock<IClass917>();
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
