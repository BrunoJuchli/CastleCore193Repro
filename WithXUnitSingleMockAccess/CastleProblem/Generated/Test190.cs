using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test190
    {
        private readonly Mock<IClass190> aClass;

        public Test190()
        {
            this.aClass = new Mock<IClass190>();
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
