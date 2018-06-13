using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test786
    {
        private readonly Mock<IClass786> aClass;

        public Test786()
        {
            this.aClass = new Mock<IClass786>();
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
