using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test265
    {
        private readonly Mock<IClass265> aClass;

        public Test265()
        {
            this.aClass = new Mock<IClass265>();
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
