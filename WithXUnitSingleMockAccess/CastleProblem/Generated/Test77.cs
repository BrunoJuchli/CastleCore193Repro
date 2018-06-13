using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test77
    {
        private readonly Mock<IClass77> aClass;

        public Test77()
        {
            this.aClass = new Mock<IClass77>();
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
