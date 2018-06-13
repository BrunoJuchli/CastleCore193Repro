using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test660
    {
        private readonly Mock<IClass660> aClass;

        public Test660()
        {
            this.aClass = new Mock<IClass660>();
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
