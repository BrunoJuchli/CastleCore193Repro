using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test316
    {
        private readonly Mock<IClass316> aClass;

        public Test316()
        {
            this.aClass = new Mock<IClass316>();
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
