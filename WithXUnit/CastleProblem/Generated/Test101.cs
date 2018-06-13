using Moq;
using Xunit;

namespace CastleProblem
{
    public class Test101
    {
        private readonly Mock<IClass101> aClass;

        public Test101()
        {
            this.aClass = new Mock<IClass101>();
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
