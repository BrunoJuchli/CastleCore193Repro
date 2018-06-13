using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test899
    {
        private readonly Mock<IClass899> aClass;

        public Test899()
        {
            this.aClass = new Mock<IClass899>();
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
